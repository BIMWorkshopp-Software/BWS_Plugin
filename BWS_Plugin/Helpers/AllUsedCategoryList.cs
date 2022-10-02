using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace BWS_Plugin
{
    internal class AllUsedCategoryList
    {
        public IEnumerable<BuiltInCategory> categoryList = new BuiltInCategory[] {
            BuiltInCategory.OST_PipeAccessory, //Арматура трубопроводов 
            BuiltInCategory.OST_MechanicalEquipment, //Оборудование 
            BuiltInCategory.OST_PlumbingFixtures, //Сантехнические приборы 
            BuiltInCategory.OST_PipeFitting, //Соединительные детали трубопроводов 
            BuiltInCategory.OST_PipeInsulations, //Материалы изоляции труб 
            BuiltInCategory.OST_DuctCurves, //Воздуховоды 
            BuiltInCategory.OST_DuctFitting, //Соединительные детали воздуховодов 
            BuiltInCategory.OST_DuctAccessory, //Арматура воздуховодов 
            BuiltInCategory.OST_DuctTerminal, //Воздухораспределители 
            BuiltInCategory.OST_CableTray, //Кабельные лотки 
            BuiltInCategory.OST_Conduit, //Короба 
            BuiltInCategory.OST_CableTrayFitting, //Соединительные детали кабельных лотков 
            BuiltInCategory.OST_ConduitFitting, //Соединительные детали коробов 
            BuiltInCategory.OST_FireAlarmDevices, //Пожарная сигнализация 
            BuiltInCategory.OST_DataDevices, //Датчики 
            BuiltInCategory.OST_ElectricalEquipment, //Электрооборудование 
            BuiltInCategory.OST_ElectricalFixtures, //Электрические приборы 
            BuiltInCategory.OST_LightingFixtures,  //Осветительные приборы 
            BuiltInCategory.OST_DuctInsulations, //Материалы изоляции воздуховодов 
            BuiltInCategory.OST_LinksAnalytical,
            BuiltInCategory.OST_Casework,
            BuiltInCategory.OST_Ceilings,
            BuiltInCategory.OST_Columns,
            BuiltInCategory.OST_CommunicationDevices,
            BuiltInCategory.OST_CurtainWallPanels,
            BuiltInCategory.OST_CurtaSystem,
            BuiltInCategory.OST_CurtainWallMullions,
            BuiltInCategory.OST_DetailComponents,
            BuiltInCategory.OST_Doors,
            BuiltInCategory.OST_ElectricalCircuit,
            BuiltInCategory.OST_Entourage,
            BuiltInCategory.OST_FlexDuctCurves,
            BuiltInCategory.OST_FlexPipeCurves,
            BuiltInCategory.OST_Floors,
            BuiltInCategory.OST_Furniture,
            BuiltInCategory.OST_FurnitureSystems,
            BuiltInCategory.OST_GenericModel,
            BuiltInCategory.OST_LightingDevices,
            BuiltInCategory.OST_Mass,
            BuiltInCategory.OST_NurseCallDevices,
            BuiltInCategory.OST_Parking,
            BuiltInCategory.OST_Parts,
            BuiltInCategory.OST_PipeCurves,
            BuiltInCategory.OST_StairsRailing,
            BuiltInCategory.OST_Ramps,
            BuiltInCategory.OST_RebarShape,
            BuiltInCategory.OST_Roofs,
            BuiltInCategory.OST_SecurityDevices,
            BuiltInCategory.OST_ShaftOpening,
            BuiltInCategory.OST_Site,
            BuiltInCategory.OST_MEPSpaces,
            BuiltInCategory.OST_SpecialityEquipment,
            BuiltInCategory.OST_Sprinklers,
            BuiltInCategory.OST_Stairs,
            BuiltInCategory.OST_AreaRein,
            BuiltInCategory.OST_StructuralFramingSystem,
            BuiltInCategory.OST_StructuralColumns,
            BuiltInCategory.OST_StructConnections,
            BuiltInCategory.OST_FabricAreas,
            BuiltInCategory.OST_FabricReinforcement,
            BuiltInCategory.OST_StructuralFoundation,
            BuiltInCategory.OST_StructuralFraming,
            BuiltInCategory.OST_PathRein,
            BuiltInCategory.OST_Rebar,
            BuiltInCategory.OST_StructuralStiffener,
            BuiltInCategory.OST_StructuralTruss,
            BuiltInCategory.OST_SwitchSystem,
            BuiltInCategory.OST_TelephoneDevices,
            BuiltInCategory.OST_Walls,
            BuiltInCategory.OST_Windows,
            BuiltInCategory.OST_Wire
        };
    }
}
