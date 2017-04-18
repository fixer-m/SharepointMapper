using System;
using System.Collections.Generic;
using Shmapper;

namespace SpTest
{
    /// <summary>
    ///  Блок страницы мероприятий 
    ///  Список блоков контента мероприятий
    ///  EventBlocksList
    /// </summary>
    [SharepointList("Блок страницы мероприятий")]
    public partial class EventBlocksList : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///Title:Text , 
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for MontEvent:
        ///Lookup 
        ///Мероприятие, к которому принадлежит блок  
        /// </summary>
        [SharepointField("MontEvent", MapData.LookupId)]
        public int MontEventId { get; set; }

        ///// <summary> 
        /////lookup values for  MontEvent:Lookup , Мероприятие, к которому принадлежит блок  LookUp list Event
        ////fieldLookup.AllowMultipleValues:False
        ///// </summary>
        //public Event MontEventLookUp => (new SpRepository<Event>()).GetById(MontEventId);//todo change  new repository on get from ninject

        /// <summary>
        ///MontEvent:Lookup , Мероприятие, к которому принадлежит блок
        /// </summary>
        [SharepointField("MontEvent", MapData.LookupValue)]
        public String MontEvent { get; set; }

        /// <summary>
        ///MontBlockOrder:Number , Порядок в котором будет отображаться блок на странице (меньше - выше)
        /// </summary>
        [SharepointField("MontBlockOrder")]
        public Int32? MontBlockOrder { get; set; }

        /// <summary>
        ///lookup Id(s) for MontBlockAudience:
        ///LookupMulti 
        ///Аудитория, которой виден блок  
        /// </summary>
        [SharepointField("MontBlockAudience", MapData.LookupId)]
        public List<int> MontBlockAudienceId { get; set; }

        ///// <summary> 
        /////lookup values for  MontBlockAudience:LookupMulti , Аудитория, которой виден блок  LookUp list Audience
        ////fieldLookup.AllowMultipleValues:True
        ///// </summary>
        //public IEnumerable<Audience> MontBlockAudienceLookUp => MontBlockAudienceId.Select(l => (new SpRepository<Audience>()).GetById(l));//todo change  new repository on get from ninject

        /// <summary>
        ///MontBlockAudience:LookupMulti , Аудитория, которой виден блок
        /// </summary>
        [SharepointField("MontBlockAudience", MapData.LookupValue)]
        public List<String> MontBlockAudience { get; set; }

        /// <summary>
        ///lookup Id(s) for MontBlockType:
        ///Lookup 
        ///Тип блока  
        /// </summary>
        [SharepointField("MontBlockType", MapData.LookupId)]
        public int MontBlockTypeId { get; set; }

        ///// <summary> 
        /////lookup values for  MontBlockType:Lookup , Тип блока  LookUp list PageBlockTypeList
        ////fieldLookup.AllowMultipleValues:False
        ///// </summary>
        //public PageBlockTypeList MontBlockTypeLookUp => (new SpRepository<PageBlockTypeList>()).GetById(MontBlockTypeId);//todo change  new repository on get from ninject

        /// <summary>
        ///MontBlockType:Lookup , Тип блока
        /// </summary>
        [SharepointField("MontBlockType", MapData.LookupValue)]
        public String MontBlockType { get; set; }

        /// <summary>
        ///lookup Id(s) for MontBlockStatus:
        ///Lookup 
        ///Статус публикации блока  
        /// </summary>
        [SharepointField("MontBlockStatus", MapData.LookupId)]
        public int MontBlockStatusId { get; set; }

        ///// <summary> 
        /////lookup values for  MontBlockStatus:Lookup , Статус публикации блока  LookUp list PublishStatus
        ////fieldLookup.AllowMultipleValues:False
        ///// </summary>
        //public PublishStatus MontBlockStatusLookUp => (new SpRepository<PublishStatus>()).GetById(MontBlockStatusId);//todo change  new repository on get from ninject

        ///// <summary>
        ///MontBlockStatus:Lookup , Статус публикации блока
        /// </summary>
        [SharepointField("MontBlockStatus", MapData.LookupValue)]
        public String MontBlockStatus { get; set; }

        /// <summary>
        ///MontBlockText:Text , Текст (зависит от типа блока, например, адрес мероприятия для блока Адрес)
        /// </summary>
        [SharepointField("MontBlockText")]
        public String MontBlockText { get; set; }

        /// <summary>
        ///MontBlockHtml:Note , HTML для отображения внутри блока
        /// </summary>
        [SharepointField("MontBlockHtml")]
        public String MontBlockHtml { get; set; }

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