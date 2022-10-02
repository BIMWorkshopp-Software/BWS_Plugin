using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using System.Reflection;
using System.IO;

namespace BWS_Plugin
{
    internal class Helpers
    {
        public double FeetToMillimeters(double feet)
        {
            double a = feet;
            return a * 304.8;
        }

        public double MillimetersToFeet(double millimetrs)
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
        public string SetingsLineValue(int numberLine)
        {
            string iniPath = File.ReadAllLines(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Resources\\Setings.ini").ElementAt(numberLine);
            return iniPath;
        }
        public void ReplaceSetingsLineValue(string oldString, string newString)
        {
            var oldText = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Resources\\Setings.ini");
            var newText = oldText.Replace(oldString, newString);
            File.WriteAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Resources\\Setings.ini", newText);
        }
    }
}
