using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shmapper;

namespace SpTest
{


    [SharepointList("Блок страницы вендора")]
    public class SpVendorBlock : ISharepointItem
    {
        [SharepointField("ID")]
        public int Id { get; set; }

        [SharepointField("Title")]
        public string Title { get; set; }
    }


    [TestClass]
    public class DevSpConTest
    {
        private static  SharepointClient _sharepointClient;
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            _sharepointClient = new SharepointClient("http://sp-dev2016-obl.mont.ru/sites/b2b", new NetworkCredential("SP_Portal", "Mont2010"));
        }

        [TestMethod]
        public void TestMethod1()
        {
           
            List<SpVendorBlock> spVendorBlocks = _sharepointClient.GetAll<SpVendorBlock>();
        }
        [TestMethod]
        public void TestMethod2()
        {
           
            List<SpVendorBlock> spVendorBlocks = _sharepointClient.Query<SpVendorBlock>(vb => vb.Title == "ABBYY");
        }
        [TestMethod]
        public void MapEventBlock()
        {
           
            List<EventBlocksList> spVendorBlocks = _sharepointClient.GetAll<EventBlocksList>();

        }
        [TestMethod]
        public void GeneratePocoClasses()
        {
           
            string generatePocoClasses = _sharepointClient.GeneratePocoClasses();
            Console.Write(generatePocoClasses);
        }
        
        [SharepointList("Блок страницы мероприятий")]
        public partial class EventBlocksList : ISharepointItem // Блок страницы мероприятий
        {

            [SharepointField("ID")]
            public int Id { get; set; } //ID:Counter , 

            [SharepointField("Title")]
            public String Title { get; set; } //Title:Text , 

            [SharepointField("MontEvent", MapData.LookupId)]
            public int MontEventId { get; set; } //MontEvent:Lookup , Мероприятие, к которому принадлежит блок

            [SharepointField("MontEvent", MapData.LookupValue)]
            public String MontEvent { get; set; } //MontEvent:Lookup , Мероприятие, к которому принадлежит блок

            [SharepointField("MontBlockOrder")]
            public Int32? MontBlockOrder { get; set; } //MontBlockOrder:Number , Порядок в котором будет отображаться блок на странице (меньше - выше)

            [SharepointField("MontBlockAudience", MapData.LookupId)]
            public int MontBlockAudienceId { get; set; } //MontBlockAudience:Lookup , Аудитория, которой виден блок

            [SharepointField("MontBlockAudience", MapData.LookupValue)]
            public String MontBlockAudience { get; set; } //MontBlockAudience:Lookup , Аудитория, которой виден блок

            [SharepointField("MontBlockType", MapData.LookupId)]
            public int MontBlockTypeId { get; set; } //MontBlockType:Lookup , Тип блока

            [SharepointField("MontBlockType", MapData.LookupValue)]
            public String MontBlockType { get; set; } //MontBlockType:Lookup , Тип блока

            [SharepointField("MontBlockStatus", MapData.LookupId)]
            public int MontBlockStatusId { get; set; } //MontBlockStatus:Lookup , Статус публикации блока

            [SharepointField("MontBlockStatus", MapData.LookupValue)]
            public String MontBlockStatus { get; set; } //MontBlockStatus:Lookup , Статус публикации блока

            [SharepointField("MontBlockText")]
            public String MontBlockText { get; set; } //MontBlockText:Text , Текст (зависит от типа блока, например, адрес мероприятия для блока Адрес)

            [SharepointField("MontBlockHtml")]
            public String MontBlockHtml { get; set; } //MontBlockHtml:Note , HTML для отображения внутри блока

            [SharepointField("Modified")]
            public DateTime? Modified { get; set; } //Modified:DateTime , 

            [SharepointField("Created")]
            public DateTime? Created { get; set; } //Created:DateTime , 

            [SharepointField("Author")]
            public String Author { get; set; } //Author:User , 

            [SharepointField("Editor")]
            public String Editor { get; set; } //Editor:User , 

            [SharepointField("_UIVersionString")]
            public String _UIVersionString { get; set; } //OData__UIVersionString:Text , 

            [SharepointField("Attachments")]
            public String Attachments { get; set; } //Attachments:Attachments , 

            [SharepointField("ItemChildCount", MapData.LookupId)]
            public int ItemChildCountId { get; set; } //ItemChildCount:Lookup , 

            [SharepointField("ItemChildCount", MapData.LookupValue)]
            public String ItemChildCount { get; set; } //ItemChildCount:Lookup , 

            [SharepointField("FolderChildCount", MapData.LookupId)]
            public int FolderChildCountId { get; set; } //FolderChildCount:Lookup , 

            [SharepointField("FolderChildCount", MapData.LookupValue)]
            public String FolderChildCount { get; set; } //FolderChildCount:Lookup , 

            [SharepointField("AppAuthor", MapData.LookupId)]
            public int AppAuthorId { get; set; } //AppAuthor:Lookup , 

            [SharepointField("AppAuthor", MapData.LookupValue)]
            public String AppAuthor { get; set; } //AppAuthor:Lookup , 

            [SharepointField("AppEditor", MapData.LookupId)]
            public int AppEditorId { get; set; } //AppEditor:Lookup , 

            [SharepointField("AppEditor", MapData.LookupValue)]
            public String AppEditor { get; set; } //AppEditor:Lookup , 

        }//Блок страницы мероприятий
    }

}
