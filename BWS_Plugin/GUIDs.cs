using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWS_Plugin
{
    internal class GUIDs
    {
        
        public string ADSK_POS = "ae8ff999-1f22-4ed7-ad33-61503d85f0f4"; //Позиция
        public string ADSK_NAIMEN = "e6e0f5cd-3e26-485b-9342-23882b20eb43"; //Наименование
        public string ADSK_MARKA = "2204049c-d557-4dfc-8d70-13f19715e46d";//Тип,Марка
        public string ADSK_CODE = "2fd9e8cb-84f3-4297-b8b8-75f444e124ed"; //Код оборудования
        public string ADSK_ZAVOD = "a8cdbf7b-d60a-485e-a520-447d2055f351"; //Завод изготовитель
        public string ADSK_EDIZM = "4289cb19-9517-45de-9c02-5a74ebf5c86d"; //Единица измерения
        public string ADSK_COL = "8d057bb3-6ccd-4655-9165-55526691fe3a"; //Кол-во
        public string ADSK_MASSKG = "32989501-0d17-4916-8777-da950841c6d7"; //Масса единицы
        public string ADSK_MASStext = "a8832df7-0302-4a63-a6e1-47a01632b987"; //Масса текст
        public string ADSK_PRIM = "a85b7661-26b0-412f-979c-66af80b4b2c3"; //Примечание 
        public string ADSK_OBOZ = "9c98831b-9450-412d-b072-7d69b39f4029"; //Обозначение 
        public string ADSK_TOLSTENKI = "381b467b-3518-42bb-b183-35169c9bdfb3";//Толщина стенки
        public string BRU_Cabel = "37ed1cf0-fd7c-41c6-a121-5f2b1cd160bd";//BRU_Кабель
        public string BRU_SposobProkladki = "47de5ad2-6bb2-4baf-9e43-d60589ee6a4e";//BRU_Способ прокладки
        public string BRU_RazdelElementa = "236b528f-3d8b-4863-9b77-8341774f5ca0";//BRU_Раздел элемента

        //Параметры для штампов
        public string ADSK_FAM1 = "a856a784-03da-4238-9bd9-9881b9938b8a";
        public string ADSK_FAM2 = "6ca82d36-9c55-450a-a479-002c4736cc06";
        public string ADSK_FAM3 = "15284426-f3d8-4c55-9a6c-f9eea1393db3";
        public string ADSK_FAM4 = "7f45f58c-1a5e-48f5-b292-bbf312c0bf2e";
        public string ADSK_FAM5 = "6153ed75-b3d0-4e9a-ade5-f851a2a4cab6";
        public string ADSK_FAM6 = "00178540-addd-412e-83e5-76db04dbb325";

        public string ADSK_DOL1 = "ab409417-2d5e-4f75-aa6a-204cc4ee6f74";
        public string ADSK_DOL2 = "aa4e0636-b1b9-4ea6-8123-244a8679db0e";
        public string ADSK_DOL3 = "ca0521c7-fdb9-4868-8047-9e81c665c9c7";
        public string ADSK_DOL4 = "1031a769-0efa-4811-a2bc-d2f2e15b7ba7";
        public string ADSK_DOL5 = "59e76a65-de10-4091-9763-6e923deab89a";
        public string ADSK_DOL6 = "bbdefec1-06b8-45e7-8e89-9e3ccbaf29b2";

        public IEnumerable<string> ADSK_SHEET_LASTNAME = new string[] {
        "a856a784-03da-4238-9bd9-9881b9938b8a",
        "6ca82d36-9c55-450a-a479-002c4736cc06",
        "15284426-f3d8-4c55-9a6c-f9eea1393db3",
        "7f45f58c-1a5e-48f5-b292-bbf312c0bf2e",
        "6153ed75-b3d0-4e9a-ade5-f851a2a4cab6",
        "00178540-addd-412e-83e5-76db04dbb325"};

        public IEnumerable<string> ADSK_SHEET_DOLZHNOST = new string[] {
        "ab409417-2d5e-4f75-aa6a-204cc4ee6f74",
        "aa4e0636-b1b9-4ea6-8123-244a8679db0e",
        "ca0521c7-fdb9-4868-8047-9e81c665c9c7",
        "1031a769-0efa-4811-a2bc-d2f2e15b7ba7",
        "59e76a65-de10-4091-9763-6e923deab89a",
        "bbdefec1-06b8-45e7-8e89-9e3ccbaf29b2"};
    }
}
