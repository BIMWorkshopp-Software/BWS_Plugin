using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace BWS_Plugin
{
    internal class Helpers
    {
        public double feetToMillimeters(double feet)
        {
            double a = feet;
            return a * 304.8;
        }

        public double millimetersToFeet(double millimetrs)
        {
            double a = millimetrs;
            return (a / 304.8);
        }
        public IList<Element> AllElementsOfCategory(Document document, BuiltInCategory category)
        {
            var collector = new FilteredElementCollector(document);
            return collector.OfCategory(category).WhereElementIsNotElementType().ToElements();
        }

        public IList<Element> AllElementsInActiveViewOfCategory(Document document, BuiltInCategory category)
        {
            var collector = new FilteredElementCollector(document, document.ActiveView.Id);
            return collector.OfCategory(category).WhereElementIsNotElementType().ToElements();
        }

        public IList<Element> AllElementsInActiveView(Document document)
        {
            var collector = new FilteredElementCollector(document, document.ActiveView.Id);
            return collector.WhereElementIsNotElementType().ToElements();
        }

        public IList<Element> AllElementsInProject(Document document)
        {
            IList<Element> allElements = new List<Element>();
            AllUsedCategoryList categories = new AllUsedCategoryList();
            foreach (var category in categories.categoryList)
            {
                try
                {
                    var elem = AllElementsOfCategory(document, category);
                    foreach (var element in elem)
                    {
                        allElements.Add(element);
                    }
                }
                catch { };
            }
            return allElements;
        }
    }
}
