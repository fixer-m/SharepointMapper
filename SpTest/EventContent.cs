using System;
using System.Collections.Generic;
using Shmapper;

namespace SpTest
{
    /// <summary>
    ///  Содержание мероприятий 
    ///  
    ///  List27List
    /// </summary>
    [SharepointList("Содержание мероприятий")]
    public partial class EventContent : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///Title:Text , 
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///MontNewsPreview:Note , 
        /// </summary>
        [SharepointField("MontNewsPreview")]
        public String MontNewsPreview { get; set; }

        /// <summary>
        ///lookup Id(s) for MontEventId:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontEventId", MapData.LookupId)]
        public int MontEventIdId { get; set; }

        /// <summary> 
        ///lookup values for  MontEventId:Lookup ,   LookUp list Event
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        // public Event MontEventIdLookUp => (new SpRepository<Event>()).GetById(MontEventIdId);//todo change  new repository on get from ninject

        /// <summary>
        ///MontEventId:Lookup , 
        /// </summary>
        [SharepointField("MontEventId", MapData.LookupValue)]
        public String MontEventId { get; set; }

        /// <summary>
        ///MontNewsTags:Text , 
        /// </summary>
        [SharepointField("MontNewsTags")]
        public String MontNewsTags { get; set; }

        /// <summary>
        ///MontEventBody:Note , 
        /// </summary>
        [SharepointField("MontEventBody")]
        public String MontEventBody { get; set; }

        /// <summary>
        ///lookup Id(s) for MontLanguage:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontLanguage", MapData.LookupId)]
        public int MontLanguageId { get; set; }

        /// <summary> 
        ///lookup values for  MontLanguage:Lookup ,   LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        //public ContentLang MontLanguageLookUp => (new SpRepository<ContentLang>()).GetById(MontLanguageId);//todo change  new repository on get from ninject

        /// <summary>
        ///MontLanguage:Lookup , 
        /// </summary>
        [SharepointField("MontLanguage", MapData.LookupValue)]
        public String MontLanguage { get; set; }

        /// <summary>
        ///MontContentBody:Note , 
        /// </summary>
        [SharepointField("MontContentBody")]
        public String MontContentBody { get; set; }

        /// <summary>
        ///MontContentPreview:Note , 
        /// </summary>
        [SharepointField("MontContentPreview")]
        public String MontContentPreview { get; set; }

        /// <summary>
        ///OldPortalEventId:Text , 
        /// </summary>
        [SharepointField("OldPortalEventId")]
        public String OldPortalEventId { get; set; }

        /// <summary>
        ///lookup Id(s) for MontTerritories:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("MontTerritories", MapData.LookupId)]
        public List<int> MontTerritoriesId { get; set; }

        /// <summary> 
        ///lookup values for  MontTerritories:LookupMulti ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        // public IEnumerable<Territory> MontTerritoriesLookUp => MontTerritoriesId.Select(l => (new SpRepository<Territory>()).GetById(l));//todo change  new repository on get from ninject

        /// <summary>
        ///MontTerritories:LookupMulti , 
        /// </summary>
        [SharepointField("MontTerritories", MapData.LookupValue)]
        public List<String> MontTerritories { get; set; }

        /// <summary>
        ///lookup Id(s) for Territory:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("Territory", MapData.LookupId)]
        public List<int> TerritoryId { get; set; }

        /// <summary> 
        ///lookup values for  Territory:LookupMulti ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        //  public IEnumerable<Territory> TerritoryLookUp => TerritoryId.Select(l => (new SpRepository<Territory>()).GetById(l));//todo change  new repository on get from ninject

        /// <summary>
        ///Territory:LookupMulti , 
        /// </summary>
        [SharepointField("Territory", MapData.LookupValue)]
        public List<String> Territory { get; set; }

        /// <summary>
        ///lookup Id(s) for MontBlocks:
        ///LookupMulti 
        ///Блоки с контентом данного мероприятия  
        /// </summary>
        [SharepointField("MontBlocks", MapData.LookupId)]
        public List<int> MontBlocksId { get; set; }


        ///lookup values for  MontBlocks:LookupMulti , Блоки с контентом данного мероприятия  LookUp list EventBlocksList
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        // public IEnumerable<EventBlocksList> MontBlocksLookUp => MontBlocksId.Select(l => (new SpRepository<EventBlocksList>()).GetById(l));//todo change  new repository on get from ninject

        /// <summary>
        ///MontBlocks:LookupMulti , Блоки с контентом данного мероприятия
        /// </summary>
        [SharepointField("MontBlocks", MapData.LookupValue)]
        public List<String> MontBlocks { get; set; }

        /// <summary>
        ///Modified:DateTime , 
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///Created:DateTime , 
        /// </summary>
        [SharepointField("Created")]
        public DateTime? Created { get; set; }

        /// <summary>
        ///lookup Id(s) for Author:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Author", MapData.LookupId)]
        public int AuthorId { get; set; }

        /// <summary>
        ///Author:User , 
        /// </summary>
        [SharepointField("Author", MapData.LookupValue)]
        public String Author { get; set; }

        /// <summary>
        ///lookup Id(s) for Editor:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Editor", MapData.LookupId)]
        public int EditorId { get; set; }

        /// <summary>
        ///Editor:User , 
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///OData__UIVersionString:Text , 
        /// </summary>
        [SharepointField("_UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///Attachments:Attachments , 
        /// </summary>
        [SharepointField("Attachments")]
        public String Attachments { get; set; }

        /// <summary>
        ///lookup Id(s) for ItemChildCount:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ItemChildCount", MapData.LookupId)]
        public int ItemChildCountId { get; set; }

        /// <summary>
        ///ItemChildCount:Lookup , 
        /// </summary>
        [SharepointField("ItemChildCount", MapData.LookupValue)]
        public String ItemChildCount { get; set; }

        /// <summary>
        ///lookup Id(s) for FolderChildCount:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("FolderChildCount", MapData.LookupId)]
        public int FolderChildCountId { get; set; }

        /// <summary>
        ///FolderChildCount:Lookup , 
        /// </summary>
        [SharepointField("FolderChildCount", MapData.LookupValue)]
        public String FolderChildCount { get; set; }

        /// <summary>
        ///lookup Id(s) for AppAuthor:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("AppAuthor", MapData.LookupId)]
        public int AppAuthorId { get; set; }

        /// <summary>
        ///AppAuthor:Lookup , 
        /// </summary>
        [SharepointField("AppAuthor", MapData.LookupValue)]
        public String AppAuthor { get; set; }

        /// <summary>
        ///lookup Id(s) for AppEditor:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupId)]
        public int AppEditorId { get; set; }

        /// <summary>
        ///AppEditor:Lookup , 
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }
}