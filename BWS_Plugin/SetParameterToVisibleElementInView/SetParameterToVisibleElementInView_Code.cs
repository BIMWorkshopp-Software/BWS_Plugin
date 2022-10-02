using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWS_Plugin
{
    [Transaction(TransactionMode.Manual)]
    public class SetParameterToVisibleElementInView_Code : IExternalCommand
    {
        static Document _doc;
        static Helpers _help;
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var uiapp = commandData.Application;
            var uidoc = uiapp.ActiveUIDocument;
            var doc = uidoc.Document;
            _doc = doc;
            _help = new Helpers();

            SetParameterToVisibleElementInView.SetParameterToVisibleElementInView_Form form = new SetParameterToVisibleElementInView.SetParameterToVisibleElementInView_Form();
            form.ShowDialog();

            //Основной код плагина

            return Result.Succeeded;
        }

        public void setParameter(string parameterName, string value)
        {
            List<Element> elements = _help.AllElementsInActiveView(_doc).ToList();
            foreach (var el in elements)
            {
                var parName = el.GetParameters(parameterName).FirstOrDefault();
                using (Transaction tr = new Transaction(_doc, "Запись параметра"))
                {
                    tr.Start();
                    try
                    {
                        parName.Set(value);
                    }
                    catch { }

                    tr.Commit();
                }

            }

        }

        public void task()
        {
            TaskDialog.Show("Запись параметра", "Запись параметра завершена");
        }

    }
}
