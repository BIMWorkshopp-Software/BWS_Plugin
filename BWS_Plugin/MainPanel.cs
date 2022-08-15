using VCRevitRibbonUtil;
using Autodesk.Revit.UI;
using BWS_Plugin.Properties;
using BWS_Plugin;



internal class MainPanel : IExternalApplication
{
    public Result OnStartup(UIControlledApplication a)
    {
        Ribbon.GetApplicationRibbon(a)
            .Tab("BWS").Panel("Плагины")
            .CreateButton<Test>("Info", "Info", b => 
            b.SetLargeImage(Resources.BWS_Logo_32)
            .SetSmallImage(Resources.BWS_Logo_16)
            .SetLongDescription("Информация о плагинах Bim Workshopp")           
            );

        return Result.Succeeded;
    }
    public Result OnShutdown(UIControlledApplication a)
    {
        return Result.Succeeded;
    }
}
