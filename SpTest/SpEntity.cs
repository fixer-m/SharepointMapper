using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shmapper;

namespace SpTest
{

    /// <summary>
    ///  DocCategory 
    ///  
    ///  DocCategoryList
    /// </summary>
    [SharepointList("DocCategory")]
    public partial class DocCategoryList : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//DocCategory

    /// <summary>
    ///  Log 
    ///  
    ///  LogList
    /// </summary>
    [SharepointList("Log")]
    public partial class LogList : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(MontMessage)MontMessage:Note ,  
        /// </summary>
        [SharepointField("MontMessage")]
        public String MontMessage { get; set; }

        /// <summary>
        ///(MontStackTrace)MontStackTrace:Note ,  
        /// </summary>
        [SharepointField("MontStackTrace")]
        public String MontStackTrace { get; set; }

        /// <summary>
        ///(MontSubsystem)MontSubsystem:Text ,  
        /// </summary>
        [SharepointField("MontSubsystem")]
        public String MontSubsystem { get; set; }

        /// <summary>
        ///(MontLevel)MontLevel:Text ,  
        /// </summary>
        [SharepointField("MontLevel")]
        public String MontLevel { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Log

    /// <summary>
    ///  MenuType 
    ///  
    ///  MenuTypeList
    /// </summary>
    [SharepointList("MenuType")]
    public partial class MenuTypeList : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//MenuType

    /// <summary>
    ///  NotificationLog 
    ///  
    ///  NotificationLogList
    /// </summary>
    [SharepointList("NotificationLog")]
    public partial class NotificationLogList : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(MontNotificationId)MontNotificationId:Text , ИД уведомления, по которому будет связан исходящее уведомление и асинхронный ответ на него 
        /// </summary>
        [SharepointField("MontNotificationId")]
        public String MontNotificationId { get; set; }

        /// <summary>
        ///(MontEventType)MontEventType:Text ,  
        /// </summary>
        [SharepointField("MontEventType")]
        public String MontEventType { get; set; }

        /// <summary>
        ///(MontListId)MontListId:Text ,  
        /// </summary>
        [SharepointField("MontListId")]
        public String MontListId { get; set; }

        /// <summary>
        ///(MontItemId)MontItemId:Number ,  
        /// </summary>
        [SharepointField("MontItemId")]
        public Int32? MontItemId { get; set; }

        /// <summary>
        ///(MontSystem)MontSystem:Text ,  
        /// </summary>
        [SharepointField("MontSystem")]
        public String MontSystem { get; set; }

        /// <summary>
        ///(MontMessage)MontMessage:Note ,  
        /// </summary>
        [SharepointField("MontMessage")]
        public String MontMessage { get; set; }

        /// <summary>
        ///(MontResult)MontResult:Text ,  
        /// </summary>
        [SharepointField("MontResult")]
        public String MontResult { get; set; }

        /// <summary>
        ///(MontItemLink)MontItemLink:URL ,  
        /// </summary>
        [SharepointField("MontItemLink")]
        public String MontItemLink { get; set; }

        /// <summary>
        ///(MontListLink)MontListLink:URL ,  
        /// </summary>
        [SharepointField("MontListLink")]
        public String MontListLink { get; set; }

        /// <summary>
        ///(MontResponsesCount)MontResponsesCount:Number ,  
        /// </summary>
        [SharepointField("MontResponsesCount")]
        public Int32? MontResponsesCount { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//NotificationLog

    /// <summary>
    ///  PortalNotificationLog 
    ///  
    ///  PortalNotificationLogList
    /// </summary>
    [SharepointList("PortalNotificationLog")]
    public partial class PortalNotificationLogList : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(ListId)ListId:Text ,  
        /// </summary>
        [SharepointField("ListId")]
        public String ListId { get; set; }

        /// <summary>
        ///(ItemId)ItemId:Number ,  
        /// </summary>
        [SharepointField("ItemId")]
        public Int32? ItemId { get; set; }

        /// <summary>
        ///(SrvCommand)SrvCommand:Text ,  
        /// </summary>
        [SharepointField("SrvCommand")]
        public String SrvCommand { get; set; }

        /// <summary>
        ///(Success)Success:Boolean ,  
        /// </summary>
        [SharepointField("Success")]
        public Boolean? Success { get; set; }

        /// <summary>
        ///(Error)Error:Note ,  
        /// </summary>
        [SharepointField("Error")]
        public String Error { get; set; }

        /// <summary>
        ///(ListName)ListName:URL ,  
        /// </summary>
        [SharepointField("ListName")]
        public String ListName { get; set; }

        /// <summary>
        ///(ItemName)ItemName:URL ,  
        /// </summary>
        [SharepointField("ItemName")]
        public String ItemName { get; set; }

        /// <summary>
        ///(ListTitle)ListTitle:Text ,  
        /// </summary>
        [SharepointField("ListTitle")]
        public String ListTitle { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//PortalNotificationLog

    /// <summary>
    ///  TerritoryLanguage 
    ///  
    ///  TerritoryLanguageList
    /// </summary>
    [SharepointList("TerritoryLanguage")]
    public partial class TerritoryLanguageList : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for Language:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Language", MapData.LookupId)]
        public int LanguageId { get; set; }

        /// <summary> 
        ///lookup values for  Language:Lookup ,   LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContentLang LanguageLookUp(ISpClient client) => client.GetById<ContentLang>(LanguageId);

        /// <summary>
        ///(Language)Language:Lookup ,  
        /// </summary>
        [SharepointField("Language", MapData.LookupValue)]
        public String Language { get; set; }

        /// <summary>
        ///lookup Id(s) for Territory:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Territory", MapData.LookupId)]
        public int TerritoryId { get; set; }

        /// <summary> 
        ///lookup values for  Territory:Lookup ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Territory TerritoryLookUp(ISpClient client) => client.GetById<Territory>(TerritoryId);

        /// <summary>
        ///(Territory)Territory:Lookup ,  
        /// </summary>
        [SharepointField("Territory", MapData.LookupValue)]
        public String Territory { get; set; }

        /// <summary>
        ///(IsActive)IsActive:Boolean ,  
        /// </summary>
        [SharepointField("IsActive")]
        public Boolean? IsActive { get; set; }

        /// <summary>
        ///(IsDefault)IsDefault:Boolean ,  
        /// </summary>
        [SharepointField("IsDefault")]
        public Boolean? IsDefault { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//TerritoryLanguage

    /// <summary>
    ///  Активы сайта 
    ///  Эта библиотека служит для хранения файлов, которые находятся на страницах этого сайта, таких как изображения на вики-страницах.
    ///  SiteAssets
    /// </summary>
    [SharepointList("Активы сайта")]
    public partial class SiteAssets : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
        /// </summary>
        [SharepointField("Author", MapData.LookupValue)]
        public String Author { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///lookup Id(s) for Editor:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Editor", MapData.LookupId)]
        public int EditorId { get; set; }

        /// <summary>
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_CopySource)OData__CopySource:Text ,  
        /// </summary>
        [SharepointField("OData__CopySource")]
        public String OData__CopySource { get; set; }

        /// <summary>
        ///lookup Id(s) for CheckoutUser:
        ///User 
        ///  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupId)]
        public int CheckoutUserId { get; set; }

        /// <summary>
        ///(CheckoutUser)CheckoutUser:User ,  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupValue)]
        public String CheckoutUser { get; set; }

        /// <summary>
        ///(FileLeafRef)FileLeafRef:File ,  
        /// </summary>
        [SharepointField("FileLeafRef")]
        public String FileLeafRef { get; set; }

        /// <summary>
        ///lookup Id(s) for OData__CheckinComment:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("_CheckinComment", MapData.LookupId)]
        public int _CheckinCommentId { get; set; }

        /// <summary>
        ///(_CheckinComment)OData__CheckinComment:Lookup ,  
        /// </summary>
        [SharepointField("OData__CheckinComment", MapData.LookupValue)]
        public String OData__CheckinComment { get; set; }

        /// <summary>
        ///lookup Id(s) for ItemChildCount:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ItemChildCount", MapData.LookupId)]
        public int ItemChildCountId { get; set; }

        /// <summary>
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentVersionString:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupId)]
        public int ParentVersionStringId { get; set; }

        /// <summary>
        ///(ParentVersionString)ParentVersionString:Lookup ,  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupValue)]
        public String ParentVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentLeafName:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupId)]
        public int ParentLeafNameId { get; set; }

        /// <summary>
        ///(ParentLeafName)ParentLeafName:Lookup ,  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupValue)]
        public String ParentLeafName { get; set; }

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

    }//Активы сайта

    /// <summary>
    ///  Аудитории 
    ///  Список содержит аудитории для публикации новостей
    ///  List2List
    /// </summary>
    [SharepointList("Аудитории")]
    public partial class Audience : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Visible)Visible:Boolean ,  
        /// </summary>
        [SharepointField("Visible")]
        public Boolean? Visible { get; set; }

        /// <summary>
        ///(DisplayTitle)DisplayTitle:Text ,  
        /// </summary>
        [SharepointField("DisplayTitle")]
        public String DisplayTitle { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Аудитории

    /// <summary>
    ///  Баннеры 
    ///  
    ///  1
    /// </summary>
    [SharepointList("Баннеры")]
    public partial class Banner : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(FileLeafRef)FileLeafRef:File ,  
        /// </summary>
        [SharepointField("FileLeafRef")]
        public String FileLeafRef { get; set; }

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(ImageWidth)ImageWidth:Integer ,  
        /// </summary>
        [SharepointField("ImageWidth")]
        public String ImageWidth { get; set; }

        /// <summary>
        ///(ImageHeight)ImageHeight:Integer ,  
        /// </summary>
        [SharepointField("ImageHeight")]
        public String ImageHeight { get; set; }

        /// <summary>
        ///(ImageCreateDate)ImageCreateDate:DateTime ,  
        /// </summary>
        [SharepointField("ImageCreateDate")]
        public DateTime? ImageCreateDate { get; set; }

        /// <summary>
        ///(Description)Description:Note , Используется в качестве замещающего текста для рисунка. 
        /// </summary>
        [SharepointField("Description")]
        public String Description { get; set; }

        /// <summary>
        ///(Keywords)Keywords:Note , Например: ландшафт, горы, лес, природа 
        /// </summary>
        [SharepointField("Keywords")]
        public String Keywords { get; set; }

        /// <summary>
        ///(BannerSize)BannerSize:Choice ,  
        /// </summary>
        [SharepointField("BannerSize")]
        public String BannerSize { get; set; }

        /// <summary>
        ///lookup Id(s) for BusinessTypes:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("BusinessTypes", MapData.LookupId)]
        public List<int> BusinessTypesId { get; set; }

        /// <summary> 
        ///lookup values for  BusinessTypes:LookupMulti ,   LookUp list BusnessType
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<BusnessType> BusinessTypesLookUp(ISpClient client) => BusinessTypesId.Select(l => client.GetById<BusnessType>(l));

        /// <summary>
        ///(BusinessTypes)BusinessTypes:LookupMulti ,  
        /// </summary>
        [SharepointField("BusinessTypes", MapData.LookupValue)]
        public List<String> BusinessTypes { get; set; }

        /// <summary>
        ///(bannerOrder)bannerOrder:Number ,  
        /// </summary>
        [SharepointField("bannerOrder")]
        public Int32 bannerOrder { get; set; }

        /// <summary>
        ///(BannerUrl)BannerUrl:URL ,  
        /// </summary>
        [SharepointField("BannerUrl")]
        public String BannerUrl { get; set; }

        /// <summary>
        ///lookup Id(s) for Countries:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("Countries", MapData.LookupId)]
        public List<int> CountriesId { get; set; }

        /// <summary> 
        ///lookup values for  Countries:LookupMulti ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Territory> CountriesLookUp(ISpClient client) => CountriesId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(Countries)Countries:LookupMulti ,  
        /// </summary>
        [SharepointField("Countries", MapData.LookupValue)]
        public List<String> Countries { get; set; }

        /// <summary>
        ///(IsDeactivated)IsDeactivated:Boolean ,  
        /// </summary>
        [SharepointField("IsDeactivated")]
        public Boolean? IsDeactivated { get; set; }

        /// <summary>
        ///(DatePublishBeg)DatePublishBeg:DateTime ,  
        /// </summary>
        [SharepointField("DatePublishBeg")]
        public DateTime? DatePublishBeg { get; set; }

        /// <summary>
        ///(DatePublishEnd)DatePublishEnd:DateTime ,  
        /// </summary>
        [SharepointField("DatePublishEnd")]
        public DateTime? DatePublishEnd { get; set; }

        /// <summary>
        ///lookup Id(s) for Menu:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("Menu", MapData.LookupId)]
        public List<int> MenuId { get; set; }

        /// <summary> 
        ///lookup values for  Menu:LookupMulti ,   LookUp list Menu
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Menu> MenuLookUp(ISpClient client) => MenuId.Select(l => client.GetById<Menu>(l));

        /// <summary>
        ///(Menu)Menu:LookupMulti ,  
        /// </summary>
        [SharepointField("Menu", MapData.LookupValue)]
        public List<String> Menu { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
        /// </summary>
        [SharepointField("Author", MapData.LookupValue)]
        public String Author { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///lookup Id(s) for Editor:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Editor", MapData.LookupId)]
        public int EditorId { get; set; }

        /// <summary>
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_CopySource)OData__CopySource:Text ,  
        /// </summary>
        [SharepointField("OData__CopySource")]
        public String OData__CopySource { get; set; }

        /// <summary>
        ///lookup Id(s) for CheckoutUser:
        ///User 
        ///  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupId)]
        public int CheckoutUserId { get; set; }

        /// <summary>
        ///(CheckoutUser)CheckoutUser:User ,  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupValue)]
        public String CheckoutUser { get; set; }

        /// <summary>
        ///lookup Id(s) for OData__CheckinComment:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("_CheckinComment", MapData.LookupId)]
        public int _CheckinCommentId { get; set; }

        /// <summary>
        ///(_CheckinComment)OData__CheckinComment:Lookup ,  
        /// </summary>
        [SharepointField("OData__CheckinComment", MapData.LookupValue)]
        public String OData__CheckinComment { get; set; }

        /// <summary>
        ///lookup Id(s) for ItemChildCount:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ItemChildCount", MapData.LookupId)]
        public int ItemChildCountId { get; set; }

        /// <summary>
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentVersionString:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupId)]
        public int ParentVersionStringId { get; set; }

        /// <summary>
        ///(ParentVersionString)ParentVersionString:Lookup ,  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupValue)]
        public String ParentVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentLeafName:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupId)]
        public int ParentLeafNameId { get; set; }

        /// <summary>
        ///(ParentLeafName)ParentLeafName:Lookup ,  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupValue)]
        public String ParentLeafName { get; set; }

    }//Баннеры

    /// <summary>
    ///  Библиотека для портала 
    ///  
    ///  VendorDocs
    /// </summary>
    [SharepointList("Библиотека для портала")]
    public partial class VendorDocs : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(FileLeafRef)FileLeafRef:File ,  
        /// </summary>
        [SharepointField("FileLeafRef")]
        public String FileLeafRef { get; set; }

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

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
        public IEnumerable<Territory> TerritoryLookUp(ISpClient client) => TerritoryId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(Territory)Territory:LookupMulti ,  
        /// </summary>
        [SharepointField("Territory", MapData.LookupValue)]
        public List<String> Territory { get; set; }

        /// <summary>
        ///lookup Id(s) for Language:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Language", MapData.LookupId)]
        public int LanguageId { get; set; }

        /// <summary> 
        ///lookup values for  Language:Lookup ,   LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContentLang LanguageLookUp(ISpClient client) => client.GetById<ContentLang>(LanguageId);

        /// <summary>
        ///(Language)Language:Lookup ,  
        /// </summary>
        [SharepointField("Language", MapData.LookupValue)]
        public String Language { get; set; }

        /// <summary>
        ///lookup Id(s) for Vendors:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("Vendors", MapData.LookupId)]
        public List<int> VendorsId { get; set; }

        /// <summary> 
        ///lookup values for  Vendors:LookupMulti ,   LookUp list Vendor
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Vendor> VendorsLookUp(ISpClient client) => VendorsId.Select(l => client.GetById<Vendor>(l));

        /// <summary>
        ///(Vendors)Vendors:LookupMulti ,  
        /// </summary>
        [SharepointField("Vendors", MapData.LookupValue)]
        public List<String> Vendors { get; set; }

        /// <summary>
        ///(DatePublishBeg)DatePublishBeg:DateTime ,  
        /// </summary>
        [SharepointField("DatePublishBeg")]
        public DateTime DatePublishBeg { get; set; }

        /// <summary>
        ///(DatePublishEnd)DatePublishEnd:DateTime ,  
        /// </summary>
        [SharepointField("DatePublishEnd")]
        public DateTime? DatePublishEnd { get; set; }

        /// <summary>
        ///(IsDeactivated)IsDeactivated:Boolean ,  
        /// </summary>
        [SharepointField("IsDeactivated")]
        public Boolean? IsDeactivated { get; set; }

        /// <summary>
        ///lookup Id(s) for DocCategory:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("DocCategory", MapData.LookupId)]
        public int DocCategoryId { get; set; }

        /// <summary> 
        ///lookup values for  DocCategory:Lookup ,   LookUp list DocCategoryList
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public DocCategoryList DocCategoryLookUp(ISpClient client) => client.GetById<DocCategoryList>(DocCategoryId);

        /// <summary>
        ///(DocCategory)DocCategory:Lookup ,  
        /// </summary>
        [SharepointField("DocCategory", MapData.LookupValue)]
        public String DocCategory { get; set; }

        /// <summary>
        ///(Comment)Comment:Note ,  
        /// </summary>
        [SharepointField("Comment")]
        public String Comment { get; set; }

        /// <summary>
        ///(SendUpdates)SendUpdates:Boolean ,  
        /// </summary>
        [SharepointField("SendUpdates")]
        public Boolean? SendUpdates { get; set; }

        /// <summary>
        ///(MontDocId)MontDocId:Text , Идентификатор документа (нужен для лиц.форм) 
        /// </summary>
        [SharepointField("MontDocId")]
        public String MontDocId { get; set; }

        /// <summary>
        ///lookup Id(s) for SharedWithUsers:
        ///UserMulti 
        ///  
        /// </summary>
        [SharepointField("SharedWithUsers", MapData.LookupId)]
        public List<int> SharedWithUsersId { get; set; }

        /// <summary>
        ///(SharedWithUsers)SharedWithUsers:UserMulti ,  
        /// </summary>
        [SharepointField("SharedWithUsers", MapData.LookupValue)]
        public List<String> SharedWithUsers { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
        /// </summary>
        [SharepointField("Author", MapData.LookupValue)]
        public String Author { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///lookup Id(s) for Editor:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Editor", MapData.LookupId)]
        public int EditorId { get; set; }

        /// <summary>
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_CopySource)OData__CopySource:Text ,  
        /// </summary>
        [SharepointField("OData__CopySource")]
        public String OData__CopySource { get; set; }

        /// <summary>
        ///lookup Id(s) for CheckoutUser:
        ///User 
        ///  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupId)]
        public int CheckoutUserId { get; set; }

        /// <summary>
        ///(CheckoutUser)CheckoutUser:User ,  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupValue)]
        public String CheckoutUser { get; set; }

        /// <summary>
        ///lookup Id(s) for OData__CheckinComment:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("_CheckinComment", MapData.LookupId)]
        public int _CheckinCommentId { get; set; }

        /// <summary>
        ///(_CheckinComment)OData__CheckinComment:Lookup ,  
        /// </summary>
        [SharepointField("OData__CheckinComment", MapData.LookupValue)]
        public String OData__CheckinComment { get; set; }

        /// <summary>
        ///lookup Id(s) for ItemChildCount:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ItemChildCount", MapData.LookupId)]
        public int ItemChildCountId { get; set; }

        /// <summary>
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentVersionString:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupId)]
        public int ParentVersionStringId { get; set; }

        /// <summary>
        ///(ParentVersionString)ParentVersionString:Lookup ,  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupValue)]
        public String ParentVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentLeafName:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupId)]
        public int ParentLeafNameId { get; set; }

        /// <summary>
        ///(ParentLeafName)ParentLeafName:Lookup ,  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupValue)]
        public String ParentLeafName { get; set; }

    }//Библиотека для портала

    /// <summary>
    ///  Библиотека стилей 
    ///  Библиотека стилей служит для хранения таблиц стилей, например файлов CSS или XSL. Таблицы стилей в этой коллекции доступны для данного сайта и его дочерних сайтов.
    ///  Style_x0020_Library
    /// </summary>
    [SharepointList("Библиотека стилей")]
    public partial class StyleLibrary : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
        /// </summary>
        [SharepointField("Author", MapData.LookupValue)]
        public String Author { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///lookup Id(s) for Editor:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Editor", MapData.LookupId)]
        public int EditorId { get; set; }

        /// <summary>
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_CopySource)OData__CopySource:Text ,  
        /// </summary>
        [SharepointField("OData__CopySource")]
        public String OData__CopySource { get; set; }

        /// <summary>
        ///lookup Id(s) for CheckoutUser:
        ///User 
        ///  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupId)]
        public int CheckoutUserId { get; set; }

        /// <summary>
        ///(CheckoutUser)CheckoutUser:User ,  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupValue)]
        public String CheckoutUser { get; set; }

        /// <summary>
        ///(FileLeafRef)FileLeafRef:File ,  
        /// </summary>
        [SharepointField("FileLeafRef")]
        public String FileLeafRef { get; set; }

        /// <summary>
        ///lookup Id(s) for OData__CheckinComment:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("_CheckinComment", MapData.LookupId)]
        public int _CheckinCommentId { get; set; }

        /// <summary>
        ///(_CheckinComment)OData__CheckinComment:Lookup ,  
        /// </summary>
        [SharepointField("OData__CheckinComment", MapData.LookupValue)]
        public String OData__CheckinComment { get; set; }

        /// <summary>
        ///lookup Id(s) for ItemChildCount:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ItemChildCount", MapData.LookupId)]
        public int ItemChildCountId { get; set; }

        /// <summary>
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentVersionString:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupId)]
        public int ParentVersionStringId { get; set; }

        /// <summary>
        ///(ParentVersionString)ParentVersionString:Lookup ,  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupValue)]
        public String ParentVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentLeafName:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupId)]
        public int ParentLeafNameId { get; set; }

        /// <summary>
        ///(ParentLeafName)ParentLeafName:Lookup ,  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupValue)]
        public String ParentLeafName { get; set; }

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

    }//Библиотека стилей

    /// <summary>
    ///  Блок страницы вендора 
    ///  Список инстансов блоков, которые находятся на страницах. Связывает тип блока, страницу, на которой он находится, а так же параметры самого блока, такие как HTML, URL картинки, URL и название ссылки. Для разных блоков заполняются разные параметры. Например, для блока «Вендор с логотипом» нужно заполнить все 4 указанных параметра, а для блока «Новости» - не надо заполнять никакие из них.
    ///  VendorPageBlockList
    /// </summary>
    [SharepointList("Блок страницы вендора")]
    public partial class VendorPageBlockList : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for MontVendorPage:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontVendorPage", MapData.LookupId)]
        public int MontVendorPageId { get; set; }

        /// <summary>
        ///(MontVendorPage)MontVendorPage:Lookup ,  
        /// </summary>
        [SharepointField("MontVendorPage", MapData.LookupValue)]
        public String MontVendorPage { get; set; }

        /// <summary>
        ///(MontBlockOrder)MontBlockOrder:Number ,  
        /// </summary>
        [SharepointField("MontBlockOrder")]
        public Int32? MontBlockOrder { get; set; }

        /// <summary>
        ///lookup Id(s) for MontBlockAudience:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontBlockAudience", MapData.LookupId)]
        public int MontBlockAudienceId { get; set; }

        /// <summary> 
        ///lookup values for  MontBlockAudience:Lookup ,   LookUp list Audience
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Audience MontBlockAudienceLookUp(ISpClient client) => client.GetById<Audience>(MontBlockAudienceId);

        /// <summary>
        ///(MontBlockAudience)MontBlockAudience:Lookup ,  
        /// </summary>
        [SharepointField("MontBlockAudience", MapData.LookupValue)]
        public String MontBlockAudience { get; set; }

        /// <summary>
        ///(MontBlockHtml)MontBlockHtml:Note ,  
        /// </summary>
        [SharepointField("MontBlockHtml")]
        public String MontBlockHtml { get; set; }

        /// <summary>
        ///(MontBlockImageUrl)MontBlockImageUrl:Text ,  
        /// </summary>
        [SharepointField("MontBlockImageUrl")]
        public String MontBlockImageUrl { get; set; }

        /// <summary>
        ///(MontBlockLinkUrl)MontBlockLinkUrl:Text ,  
        /// </summary>
        [SharepointField("MontBlockLinkUrl")]
        public String MontBlockLinkUrl { get; set; }

        /// <summary>
        ///(MontBlockImageTitle)MontBlockImageTitle:Text ,  
        /// </summary>
        [SharepointField("MontBlockImageTitle")]
        public String MontBlockImageTitle { get; set; }

        /// <summary>
        ///lookup Id(s) for MontStatus:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontStatus", MapData.LookupId)]
        public int MontStatusId { get; set; }

        /// <summary> 
        ///lookup values for  MontStatus:Lookup ,   LookUp list PublishStatus
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public PublishStatus MontStatusLookUp(ISpClient client) => client.GetById<PublishStatus>(MontStatusId);

        /// <summary>
        ///(MontStatus)MontStatus:Lookup ,  
        /// </summary>
        [SharepointField("MontStatus", MapData.LookupValue)]
        public String MontStatus { get; set; }

        /// <summary>
        ///(MontIsDeactivated)MontIsDeactivated:Boolean ,  
        /// </summary>
        [SharepointField("MontIsDeactivated")]
        public Boolean? MontIsDeactivated { get; set; }

        /// <summary>
        ///lookup Id(s) for MontPageBlockType:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontPageBlockType", MapData.LookupId)]
        public int MontPageBlockTypeId { get; set; }

        /// <summary> 
        ///lookup values for  MontPageBlockType:Lookup ,   LookUp list PageBlockTypeList
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public PageBlockTypeList MontPageBlockTypeLookUp(ISpClient client) => client.GetById<PageBlockTypeList>(MontPageBlockTypeId);

        /// <summary>
        ///(MontPageBlockType)MontPageBlockType:Lookup ,  
        /// </summary>
        [SharepointField("MontPageBlockType", MapData.LookupValue)]
        public String MontPageBlockType { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Блок страницы вендора

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
        ///(Title)Title:Text ,  
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

        /// <summary> 
        ///lookup values for  MontEvent:Lookup , Мероприятие, к которому принадлежит блок  LookUp list Event
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Event MontEventLookUp(ISpClient client) => client.GetById<Event>(MontEventId);

        /// <summary>
        ///(MontEvent)MontEvent:Lookup , Мероприятие, к которому принадлежит блок 
        /// </summary>
        [SharepointField("MontEvent", MapData.LookupValue)]
        public String MontEvent { get; set; }

        /// <summary>
        ///(MontBlockOrder)MontBlockOrder:Number , Порядок в котором будет отображаться блок на странице (меньше - выше) 
        /// </summary>
        [SharepointField("MontBlockOrder")]
        public Int32? MontBlockOrder { get; set; }

        /// <summary>
        ///lookup Id(s) for MontBlockAudience:
        ///Lookup 
        ///Аудитория, которой виден блок  
        /// </summary>
        [SharepointField("MontBlockAudience", MapData.LookupId)]
        public int MontBlockAudienceId { get; set; }

        /// <summary> 
        ///lookup values for  MontBlockAudience:Lookup , Аудитория, которой виден блок  LookUp list Audience
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Audience MontBlockAudienceLookUp(ISpClient client) => client.GetById<Audience>(MontBlockAudienceId);

        /// <summary>
        ///(MontBlockAudience)MontBlockAudience:Lookup , Аудитория, которой виден блок 
        /// </summary>
        [SharepointField("MontBlockAudience", MapData.LookupValue)]
        public String MontBlockAudience { get; set; }

        /// <summary>
        ///lookup Id(s) for MontBlockType:
        ///Lookup 
        ///Тип блока  
        /// </summary>
        [SharepointField("MontBlockType", MapData.LookupId)]
        public int MontBlockTypeId { get; set; }

        /// <summary> 
        ///lookup values for  MontBlockType:Lookup , Тип блока  LookUp list PageBlockTypeList
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public PageBlockTypeList MontBlockTypeLookUp(ISpClient client) => client.GetById<PageBlockTypeList>(MontBlockTypeId);

        /// <summary>
        ///(MontBlockType)MontBlockType:Lookup , Тип блока 
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

        /// <summary> 
        ///lookup values for  MontBlockStatus:Lookup , Статус публикации блока  LookUp list PublishStatus
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public PublishStatus MontBlockStatusLookUp(ISpClient client) => client.GetById<PublishStatus>(MontBlockStatusId);

        /// <summary>
        ///(MontBlockStatus)MontBlockStatus:Lookup , Статус публикации блока 
        /// </summary>
        [SharepointField("MontBlockStatus", MapData.LookupValue)]
        public String MontBlockStatus { get; set; }

        /// <summary>
        ///(MontBlockHtml)MontBlockHtml:Note , HTML для отображения внутри блока 
        /// </summary>
        [SharepointField("MontBlockHtml")]
        public String MontBlockHtml { get; set; }

        /// <summary>
        ///(MontBlockText)MontBlockText:Text , Текст (зависит от типа блока, например, адрес мероприятия для блока Адрес) 
        /// </summary>
        [SharepointField("MontBlockText")]
        public String MontBlockText { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Блок страницы мероприятий

    /// <summary>
    ///  Вендоры 
    ///  Список вендоров
    ///  List5List
    /// </summary>
    [SharepointList("Вендоры")]
    public partial class Vendor : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(VendorCode)VendorCode:Text ,  
        /// </summary>
        [SharepointField("VendorCode")]
        public String VendorCode { get; set; }

        /// <summary>
        ///lookup Id(s) for BusinessLines:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("BusinessLines", MapData.LookupId)]
        public List<int> BusinessLinesId { get; set; }

        /// <summary> 
        ///lookup values for  BusinessLines:LookupMulti ,   LookUp list BusnessType
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<BusnessType> BusinessLinesLookUp(ISpClient client) => BusinessLinesId.Select(l => client.GetById<BusnessType>(l));

        /// <summary>
        ///(BusinessLines)BusinessLines:LookupMulti ,  
        /// </summary>
        [SharepointField("BusinessLines", MapData.LookupValue)]
        public List<String> BusinessLines { get; set; }

        /// <summary>
        ///(BadgeTitle)BadgeTitle:Text , Используется для отображения плашек с названием вендора 
        /// </summary>
        [SharepointField("BadgeTitle")]
        public String BadgeTitle { get; set; }

        /// <summary>
        ///lookup Id(s) for Territories:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("Territories", MapData.LookupId)]
        public List<int> TerritoriesId { get; set; }

        /// <summary> 
        ///lookup values for  Territories:LookupMulti ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Territory> TerritoriesLookUp(ISpClient client) => TerritoriesId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(Territories)Territories:LookupMulti ,  
        /// </summary>
        [SharepointField("Territories", MapData.LookupValue)]
        public List<String> Territories { get; set; }

        /// <summary>
        ///(Deactivated)Deactivated:Boolean ,  
        /// </summary>
        [SharepointField("Deactivated")]
        public Boolean? Deactivated { get; set; }

        /// <summary>
        ///(OldPortalId)OldPortalId:Number ,  
        /// </summary>
        [SharepointField("OldPortalId")]
        public Int32? OldPortalId { get; set; }

        /// <summary>
        ///(IsHidden)IsHidden:Boolean ,  
        /// </summary>
        [SharepointField("IsHidden")]
        public Boolean? IsHidden { get; set; }

        /// <summary>
        ///(VendorLogoUrl)VendorLogoUrl:URL , логотип вендора 
        /// </summary>
        [SharepointField("VendorLogoUrl")]
        public String VendorLogoUrl { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Вендоры

    /// <summary>
    ///  Вендоры локализация 
    ///  
    ///  List3List
    /// </summary>
    [SharepointList("Вендоры локализация")]
    public partial class VendorLocalization : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(VendorLink)VendorLink:Note ,  
        /// </summary>
        [SharepointField("VendorLink")]
        public String VendorLink { get; set; }

        /// <summary>
        ///lookup Id(s) for Language:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Language", MapData.LookupId)]
        public int LanguageId { get; set; }

        /// <summary> 
        ///lookup values for  Language:Lookup ,   LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContentLang LanguageLookUp(ISpClient client) => client.GetById<ContentLang>(LanguageId);

        /// <summary>
        ///(Language)Language:Lookup ,  
        /// </summary>
        [SharepointField("Language", MapData.LookupValue)]
        public String Language { get; set; }

        /// <summary>
        ///lookup Id(s) for Vendor:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Vendor", MapData.LookupId)]
        public int VendorId { get; set; }

        /// <summary> 
        ///lookup values for  Vendor:Lookup ,   LookUp list Vendor
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Vendor VendorLookUp(ISpClient client) => client.GetById<Vendor>(VendorId);

        /// <summary>
        ///(Vendor)Vendor:Lookup ,  
        /// </summary>
        [SharepointField("Vendor", MapData.LookupValue)]
        public String Vendor { get; set; }

        /// <summary>
        ///lookup Id(s) for Country:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Country", MapData.LookupId)]
        public int CountryId { get; set; }

        /// <summary> 
        ///lookup values for  Country:Lookup ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Territory CountryLookUp(ISpClient client) => client.GetById<Territory>(CountryId);

        /// <summary>
        ///(Country)Country:Lookup ,  
        /// </summary>
        [SharepointField("Country", MapData.LookupValue)]
        public String Country { get; set; }

        /// <summary>
        ///lookup Id(s) for BusinessTypes:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("BusinessTypes", MapData.LookupId)]
        public List<int> BusinessTypesId { get; set; }

        /// <summary> 
        ///lookup values for  BusinessTypes:LookupMulti ,   LookUp list BusnessType
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<BusnessType> BusinessTypesLookUp(ISpClient client) => BusinessTypesId.Select(l => client.GetById<BusnessType>(l));

        /// <summary>
        ///(BusinessTypes)BusinessTypes:LookupMulti ,  
        /// </summary>
        [SharepointField("BusinessTypes", MapData.LookupValue)]
        public List<String> BusinessTypes { get; set; }

        /// <summary>
        ///(VendorDescription)VendorDescription:Note ,  
        /// </summary>
        [SharepointField("VendorDescription")]
        public String VendorDescription { get; set; }

        /// <summary>
        ///(PublishDescription)PublishDescription:Boolean ,  
        /// </summary>
        [SharepointField("PublishDescription")]
        public Boolean? PublishDescription { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Вендоры локализация

    /// <summary>
    ///  Вложения 
    ///  
    ///  DocLib
    /// </summary>
    [SharepointList("Вложения")]
    public partial class DocLib : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
        /// </summary>
        [SharepointField("Author", MapData.LookupValue)]
        public String Author { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///lookup Id(s) for Editor:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Editor", MapData.LookupId)]
        public int EditorId { get; set; }

        /// <summary>
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_CopySource)OData__CopySource:Text ,  
        /// </summary>
        [SharepointField("OData__CopySource")]
        public String OData__CopySource { get; set; }

        /// <summary>
        ///lookup Id(s) for CheckoutUser:
        ///User 
        ///  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupId)]
        public int CheckoutUserId { get; set; }

        /// <summary>
        ///(CheckoutUser)CheckoutUser:User ,  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupValue)]
        public String CheckoutUser { get; set; }

        /// <summary>
        ///(FileLeafRef)FileLeafRef:File ,  
        /// </summary>
        [SharepointField("FileLeafRef")]
        public String FileLeafRef { get; set; }

        /// <summary>
        ///lookup Id(s) for OData__CheckinComment:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("_CheckinComment", MapData.LookupId)]
        public int _CheckinCommentId { get; set; }

        /// <summary>
        ///(_CheckinComment)OData__CheckinComment:Lookup ,  
        /// </summary>
        [SharepointField("OData__CheckinComment", MapData.LookupValue)]
        public String OData__CheckinComment { get; set; }

        /// <summary>
        ///lookup Id(s) for ItemChildCount:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ItemChildCount", MapData.LookupId)]
        public int ItemChildCountId { get; set; }

        /// <summary>
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentVersionString:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupId)]
        public int ParentVersionStringId { get; set; }

        /// <summary>
        ///(ParentVersionString)ParentVersionString:Lookup ,  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupValue)]
        public String ParentVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentLeafName:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupId)]
        public int ParentLeafNameId { get; set; }

        /// <summary>
        ///(ParentLeafName)ParentLeafName:Lookup ,  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupValue)]
        public String ParentLeafName { get; set; }

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

    }//Вложения

    /// <summary>
    ///  Группы доступа 
    ///  
    ///  List4List
    /// </summary>
    [SharepointList("Группы доступа")]
    public partial class AudienceRole : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Role)Role:Choice ,  
        /// </summary>
        [SharepointField("Role")]
        public String Role { get; set; }

        /// <summary>
        ///lookup Id(s) for Audience:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("Audience", MapData.LookupId)]
        public List<int> AudienceId { get; set; }

        /// <summary> 
        ///lookup values for  Audience:LookupMulti ,   LookUp list Audience
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Audience> AudienceLookUp(ISpClient client) => AudienceId.Select(l => client.GetById<Audience>(l));

        /// <summary>
        ///(Audience)Audience:LookupMulti ,  
        /// </summary>
        [SharepointField("Audience", MapData.LookupValue)]
        public List<String> Audience { get; set; }

        /// <summary>
        ///lookup Id(s) for PublishingStatus:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("PublishingStatus", MapData.LookupId)]
        public List<int> PublishingStatusId { get; set; }

        /// <summary> 
        ///lookup values for  PublishingStatus:LookupMulti ,   LookUp list PublishStatus
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<PublishStatus> PublishingStatusLookUp(ISpClient client) => PublishingStatusId.Select(l => client.GetById<PublishStatus>(l));

        /// <summary>
        ///(PublishingStatus)PublishingStatus:LookupMulti ,  
        /// </summary>
        [SharepointField("PublishingStatus", MapData.LookupValue)]
        public List<String> PublishingStatus { get; set; }

        /// <summary>
        ///(IsResident)IsResident:Boolean ,  
        /// </summary>
        [SharepointField("IsResident")]
        public Boolean? IsResident { get; set; }

        /// <summary>
        ///lookup Id(s) for PublishingStatus_x003a__x041a__x:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("PublishingStatus_x003a__x041a__x", MapData.LookupId)]
        public List<int> PublishingStatus_x003a__x041a__xId { get; set; }

        /// <summary> 
        ///lookup values for  PublishingStatus_x003a__x041a__x:LookupMulti ,   LookUp list PublishStatus
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<PublishStatus> PublishingStatus_x003a__x041a__xLookUp(ISpClient client) => PublishingStatus_x003a__x041a__xId.Select(l => client.GetById<PublishStatus>(l));

        /// <summary>
        ///(PublishingStatus_x003a__x041a__x)PublishingStatus_x003a__x041a__x:LookupMulti ,  
        /// </summary>
        [SharepointField("PublishingStatus_x003a__x041a__x", MapData.LookupValue)]
        public List<String> PublishingStatus_x003a__x041a__x { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Группы доступа

    /// <summary>
    ///  Документы 
    ///  
    ///  Shared_x0020_Documents
    /// </summary>
    [SharepointList("Документы")]
    public partial class SharedDocuments : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(FileLeafRef)FileLeafRef:File ,  
        /// </summary>
        [SharepointField("FileLeafRef")]
        public String FileLeafRef { get; set; }

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(PublishingStartDate)PublishingStartDate:PublishingScheduleStartDateFieldType , "Дата начала расписания" — это столбец сайта, созданный средством публикации. Он используется для указания даты и времени первого отображения данной страницы для посетителей сайта. 
        /// </summary>
        [SharepointField("PublishingStartDate")]
        public String PublishingStartDate { get; set; }

        /// <summary>
        ///(PublishingExpirationDate)PublishingExpirationDate:PublishingScheduleEndDateFieldType , "Дата окончания расписания" — это столбец сайта, созданный средством публикации. Он используется для указания даты и времени прекращения отображения данной страницы для посетителей сайта. 
        /// </summary>
        [SharepointField("PublishingExpirationDate")]
        public String PublishingExpirationDate { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
        /// </summary>
        [SharepointField("Author", MapData.LookupValue)]
        public String Author { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///lookup Id(s) for Editor:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Editor", MapData.LookupId)]
        public int EditorId { get; set; }

        /// <summary>
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_CopySource)OData__CopySource:Text ,  
        /// </summary>
        [SharepointField("OData__CopySource")]
        public String OData__CopySource { get; set; }

        /// <summary>
        ///lookup Id(s) for CheckoutUser:
        ///User 
        ///  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupId)]
        public int CheckoutUserId { get; set; }

        /// <summary>
        ///(CheckoutUser)CheckoutUser:User ,  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupValue)]
        public String CheckoutUser { get; set; }

        /// <summary>
        ///lookup Id(s) for OData__CheckinComment:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("_CheckinComment", MapData.LookupId)]
        public int _CheckinCommentId { get; set; }

        /// <summary>
        ///(_CheckinComment)OData__CheckinComment:Lookup ,  
        /// </summary>
        [SharepointField("OData__CheckinComment", MapData.LookupValue)]
        public String OData__CheckinComment { get; set; }

        /// <summary>
        ///lookup Id(s) for ItemChildCount:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ItemChildCount", MapData.LookupId)]
        public int ItemChildCountId { get; set; }

        /// <summary>
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentVersionString:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupId)]
        public int ParentVersionStringId { get; set; }

        /// <summary>
        ///(ParentVersionString)ParentVersionString:Lookup ,  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupValue)]
        public String ParentVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentLeafName:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupId)]
        public int ParentLeafNameId { get; set; }

        /// <summary>
        ///(ParentLeafName)ParentLeafName:Lookup ,  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupValue)]
        public String ParentLeafName { get; set; }

    }//Документы

    /// <summary>
    ///  Задачи рабочего процесса 
    ///  
    ///  List36List
    /// </summary>
    [SharepointList("Задачи рабочего процесса")]
    public partial class WorkProcessTask : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

        /// <summary>
        ///lookup Id(s) for Predecessors:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("Predecessors", MapData.LookupId)]
        public List<int> PredecessorsId { get; set; }

        /// <summary> 
        ///lookup values for  Predecessors:LookupMulti ,   LookUp list WorkProcessTask
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<WorkProcessTask> PredecessorsLookUp(ISpClient client) => PredecessorsId.Select(l => client.GetById<WorkProcessTask>(l));

        /// <summary>
        ///(Predecessors)Predecessors:LookupMulti ,  
        /// </summary>
        [SharepointField("Predecessors", MapData.LookupValue)]
        public List<String> Predecessors { get; set; }

        /// <summary>
        ///(Priority)Priority:Choice ,  
        /// </summary>
        [SharepointField("Priority")]
        public String Priority { get; set; }

        /// <summary>
        ///(Status)Status:Choice ,  
        /// </summary>
        [SharepointField("Status")]
        public String Status { get; set; }

        /// <summary>
        ///(PercentComplete)PercentComplete:Number ,  
        /// </summary>
        [SharepointField("PercentComplete")]
        public Int32? PercentComplete { get; set; }

        /// <summary>
        ///lookup Id(s) for AssignedTo:
        ///User 
        ///  
        /// </summary>
        [SharepointField("AssignedTo", MapData.LookupId)]
        public int AssignedToId { get; set; }

        /// <summary>
        ///(AssignedTo)AssignedTo:User ,  
        /// </summary>
        [SharepointField("AssignedTo", MapData.LookupValue)]
        public String AssignedTo { get; set; }

        /// <summary>
        ///lookup Id(s) for TaskGroup:
        ///User 
        ///  
        /// </summary>
        [SharepointField("TaskGroup", MapData.LookupId)]
        public int TaskGroupId { get; set; }

        /// <summary>
        ///(TaskGroup)TaskGroup:User ,  
        /// </summary>
        [SharepointField("TaskGroup", MapData.LookupValue)]
        public String TaskGroup { get; set; }

        /// <summary>
        ///(Body)Body:Note ,  
        /// </summary>
        [SharepointField("Body")]
        public String Body { get; set; }

        /// <summary>
        ///(StartDate)StartDate:DateTime ,  
        /// </summary>
        [SharepointField("StartDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        ///(DueDate)DueDate:DateTime ,  
        /// </summary>
        [SharepointField("DueDate")]
        public DateTime? DueDate { get; set; }

        /// <summary>
        ///(RelatedItems)RelatedItems:RelatedItems ,  
        /// </summary>
        [SharepointField("RelatedItems")]
        public String RelatedItems { get; set; }

    }//Задачи рабочего процесса

    /// <summary>
    ///  Изображения 
    ///  
    ///  DocLib1
    /// </summary>
    [SharepointList("Изображения")]
    public partial class Image : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
        /// </summary>
        [SharepointField("Author", MapData.LookupValue)]
        public String Author { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///lookup Id(s) for Editor:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Editor", MapData.LookupId)]
        public int EditorId { get; set; }

        /// <summary>
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_CopySource)OData__CopySource:Text ,  
        /// </summary>
        [SharepointField("OData__CopySource")]
        public String OData__CopySource { get; set; }

        /// <summary>
        ///lookup Id(s) for CheckoutUser:
        ///User 
        ///  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupId)]
        public int CheckoutUserId { get; set; }

        /// <summary>
        ///(CheckoutUser)CheckoutUser:User ,  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupValue)]
        public String CheckoutUser { get; set; }

        /// <summary>
        ///(FileLeafRef)FileLeafRef:File ,  
        /// </summary>
        [SharepointField("FileLeafRef")]
        public String FileLeafRef { get; set; }

        /// <summary>
        ///lookup Id(s) for OData__CheckinComment:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("_CheckinComment", MapData.LookupId)]
        public int _CheckinCommentId { get; set; }

        /// <summary>
        ///(_CheckinComment)OData__CheckinComment:Lookup ,  
        /// </summary>
        [SharepointField("OData__CheckinComment", MapData.LookupValue)]
        public String OData__CheckinComment { get; set; }

        /// <summary>
        ///lookup Id(s) for ItemChildCount:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ItemChildCount", MapData.LookupId)]
        public int ItemChildCountId { get; set; }

        /// <summary>
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentVersionString:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupId)]
        public int ParentVersionStringId { get; set; }

        /// <summary>
        ///(ParentVersionString)ParentVersionString:Lookup ,  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupValue)]
        public String ParentVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentLeafName:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupId)]
        public int ParentLeafNameId { get; set; }

        /// <summary>
        ///(ParentLeafName)ParentLeafName:Lookup ,  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupValue)]
        public String ParentLeafName { get; set; }

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

    }//Изображения

    /// <summary>
    ///  Изображения семейства веб-сайтов 
    ///  Эта системная библиотека была создана средством "Ресурсы публикации" для хранения изображений, используемых данным семейством веб-сайтов.
    ///  SiteCollectionImages
    /// </summary>
    [SharepointList("Изображения семейства веб-сайтов")]
    public partial class SiteCollectionImages : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(FileLeafRef)FileLeafRef:File ,  
        /// </summary>
        [SharepointField("FileLeafRef")]
        public String FileLeafRef { get; set; }

        /// <summary>
        ///(_Author)OData__Author:Text , Первоначальный автор 
        /// </summary>
        [SharepointField("OData__Author")]
        public String OData__Author { get; set; }

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(ImageWidth)ImageWidth:Integer ,  
        /// </summary>
        [SharepointField("ImageWidth")]
        public String ImageWidth { get; set; }

        /// <summary>
        ///(ImageHeight)ImageHeight:Integer ,  
        /// </summary>
        [SharepointField("ImageHeight")]
        public String ImageHeight { get; set; }

        /// <summary>
        ///(ImageCreateDate)ImageCreateDate:DateTime ,  
        /// </summary>
        [SharepointField("ImageCreateDate")]
        public DateTime? ImageCreateDate { get; set; }

        /// <summary>
        ///(_Comments)OData__Comments:Note , Сводка для этого актива 
        /// </summary>
        [SharepointField("OData__Comments")]
        public String OData__Comments { get; set; }

        /// <summary>
        ///(Keywords)Keywords:Note , Например: ландшафт, горы, лес, природа 
        /// </summary>
        [SharepointField("Keywords")]
        public String Keywords { get; set; }

        /// <summary>
        ///(wic_System_Copyright)wic_System_Copyright:Text ,  
        /// </summary>
        [SharepointField("wic_System_Copyright")]
        public String wic_System_Copyright { get; set; }

        /// <summary>
        ///(AlternateThumbnailUrl)AlternateThumbnailUrl:URL , Ссылка на изображение предварительного просмотра для этого актива 
        /// </summary>
        [SharepointField("AlternateThumbnailUrl")]
        public String AlternateThumbnailUrl { get; set; }

        /// <summary>
        ///(MediaLengthInSeconds)MediaLengthInSeconds:Integer ,  
        /// </summary>
        [SharepointField("MediaLengthInSeconds")]
        public String MediaLengthInSeconds { get; set; }

        /// <summary>
        ///(VideoWidthInPixels)VideoWidthInPixels:Integer ,  
        /// </summary>
        [SharepointField("VideoWidthInPixels")]
        public String VideoWidthInPixels { get; set; }

        /// <summary>
        ///(VideoHeightInPixels)VideoHeightInPixels:Integer ,  
        /// </summary>
        [SharepointField("VideoHeightInPixels")]
        public String VideoHeightInPixels { get; set; }

        /// <summary>
        ///(VideoRenditionLabel)VideoRenditionLabel:Text , Текст, отображаемый в видеопроигрывателе для данного представления 
        /// </summary>
        [SharepointField("VideoRenditionLabel")]
        public String VideoRenditionLabel { get; set; }

        /// <summary>
        ///(VideoRenditionBitRate)VideoRenditionBitRate:Integer ,  
        /// </summary>
        [SharepointField("VideoRenditionBitRate")]
        public String VideoRenditionBitRate { get; set; }

        /// <summary>
        ///(VideoSetDescription)VideoSetDescription:Note , Сводка видео 
        /// </summary>
        [SharepointField("VideoSetDescription")]
        public String VideoSetDescription { get; set; }

        /// <summary>
        ///lookup Id(s) for VideoSetOwner:
        ///User 
        ///Владелец видео  
        /// </summary>
        [SharepointField("VideoSetOwner", MapData.LookupId)]
        public int VideoSetOwnerId { get; set; }

        /// <summary>
        ///(VideoSetOwner)VideoSetOwner:User , Владелец видео 
        /// </summary>
        [SharepointField("VideoSetOwner", MapData.LookupValue)]
        public String VideoSetOwner { get; set; }

        /// <summary>
        ///(VideoSetShowDownloadLink)VideoSetShowDownloadLink:Boolean , Определяет, отображается ли на странице видеопроигрывателя кнопка, позволяющая пользователю скачать воспроизводимое видео. 
        /// </summary>
        [SharepointField("VideoSetShowDownloadLink")]
        public Boolean? VideoSetShowDownloadLink { get; set; }

        /// <summary>
        ///(VideoSetShowEmbedLink)VideoSetShowEmbedLink:Boolean , Определяет, отображается ли на странице видеопроигрывателя кнопка, позволяющая пользователю получить код внедрения воспроизводимого видео. 
        /// </summary>
        [SharepointField("VideoSetShowEmbedLink")]
        public Boolean? VideoSetShowEmbedLink { get; set; }

        /// <summary>
        ///lookup Id(s) for PeopleInMedia:
        ///UserMulti 
        ///Люди, показанные в этом видео.  
        /// </summary>
        [SharepointField("PeopleInMedia", MapData.LookupId)]
        public List<int> PeopleInMediaId { get; set; }

        /// <summary>
        ///(PeopleInMedia)PeopleInMedia:UserMulti , Люди, показанные в этом видео. 
        /// </summary>
        [SharepointField("PeopleInMedia", MapData.LookupValue)]
        public List<String> PeopleInMedia { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
        /// </summary>
        [SharepointField("Author", MapData.LookupValue)]
        public String Author { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///lookup Id(s) for Editor:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Editor", MapData.LookupId)]
        public int EditorId { get; set; }

        /// <summary>
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_CopySource)OData__CopySource:Text ,  
        /// </summary>
        [SharepointField("OData__CopySource")]
        public String OData__CopySource { get; set; }

        /// <summary>
        ///lookup Id(s) for CheckoutUser:
        ///User 
        ///  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupId)]
        public int CheckoutUserId { get; set; }

        /// <summary>
        ///(CheckoutUser)CheckoutUser:User ,  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupValue)]
        public String CheckoutUser { get; set; }

        /// <summary>
        ///lookup Id(s) for OData__CheckinComment:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("_CheckinComment", MapData.LookupId)]
        public int _CheckinCommentId { get; set; }

        /// <summary>
        ///(_CheckinComment)OData__CheckinComment:Lookup ,  
        /// </summary>
        [SharepointField("OData__CheckinComment", MapData.LookupValue)]
        public String OData__CheckinComment { get; set; }

        /// <summary>
        ///lookup Id(s) for ItemChildCount:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ItemChildCount", MapData.LookupId)]
        public int ItemChildCountId { get; set; }

        /// <summary>
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentVersionString:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupId)]
        public int ParentVersionStringId { get; set; }

        /// <summary>
        ///(ParentVersionString)ParentVersionString:Lookup ,  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupValue)]
        public String ParentVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentLeafName:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupId)]
        public int ParentLeafNameId { get; set; }

        /// <summary>
        ///(ParentLeafName)ParentLeafName:Lookup ,  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupValue)]
        public String ParentLeafName { get; set; }

    }//Изображения семейства веб-сайтов

    /// <summary>
    ///  Категории 
    ///  
    ///  List39List
    /// </summary>
    [SharepointList("Категории")]
    public partial class Category : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Order0)Order0:Number ,  
        /// </summary>
        [SharepointField("Order0")]
        public Int32 Order0 { get; set; }

        /// <summary>
        ///lookup Id(s) for Parent:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Parent", MapData.LookupId)]
        public int ParentId { get; set; }

        /// <summary> 
        ///lookup values for  Parent:Lookup ,   LookUp list Category
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Category ParentLookUp(ISpClient client) => client.GetById<Category>(ParentId);

        /// <summary>
        ///(Parent)Parent:Lookup ,  
        /// </summary>
        [SharepointField("Parent", MapData.LookupValue)]
        public String Parent { get; set; }

        /// <summary>
        ///lookup Id(s) for Menu:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Menu", MapData.LookupId)]
        public int MenuId { get; set; }

        /// <summary> 
        ///lookup values for  Menu:Lookup ,   LookUp list Menu
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Menu MenuLookUp(ISpClient client) => client.GetById<Menu>(MenuId);

        /// <summary>
        ///(Menu)Menu:Lookup ,  
        /// </summary>
        [SharepointField("Menu", MapData.LookupValue)]
        public String Menu { get; set; }

        /// <summary>
        ///lookup Id(s) for BusinessDirection:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("BusinessDirection", MapData.LookupId)]
        public List<int> BusinessDirectionId { get; set; }

        /// <summary> 
        ///lookup values for  BusinessDirection:LookupMulti ,   LookUp list BusnessType
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<BusnessType> BusinessDirectionLookUp(ISpClient client) => BusinessDirectionId.Select(l => client.GetById<BusnessType>(l));

        /// <summary>
        ///(BusinessDirection)BusinessDirection:LookupMulti ,  
        /// </summary>
        [SharepointField("BusinessDirection", MapData.LookupValue)]
        public List<String> BusinessDirection { get; set; }

        /// <summary>
        ///lookup Id(s) for Country:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Country", MapData.LookupId)]
        public int CountryId { get; set; }

        /// <summary> 
        ///lookup values for  Country:Lookup ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Territory CountryLookUp(ISpClient client) => client.GetById<Territory>(CountryId);

        /// <summary>
        ///(Country)Country:Lookup ,  
        /// </summary>
        [SharepointField("Country", MapData.LookupValue)]
        public String Country { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Категории

    /// <summary>
    ///  Категории локализация 
    ///  
    ///  List40List
    /// </summary>
    [SharepointList("Категории локализация")]
    public partial class CategoryLocalization : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for Language:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Language", MapData.LookupId)]
        public int LanguageId { get; set; }

        /// <summary> 
        ///lookup values for  Language:Lookup ,   LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContentLang LanguageLookUp(ISpClient client) => client.GetById<ContentLang>(LanguageId);

        /// <summary>
        ///(Language)Language:Lookup ,  
        /// </summary>
        [SharepointField("Language", MapData.LookupValue)]
        public String Language { get; set; }

        /// <summary>
        ///lookup Id(s) for Category:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Category", MapData.LookupId)]
        public int CategoryId { get; set; }

        /// <summary> 
        ///lookup values for  Category:Lookup ,   LookUp list Category
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Category CategoryLookUp(ISpClient client) => client.GetById<Category>(CategoryId);

        /// <summary>
        ///(Category)Category:Lookup ,  
        /// </summary>
        [SharepointField("Category", MapData.LookupValue)]
        public String Category { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Категории локализация

    /// <summary>
    ///  Контакты 
    ///  
    ///  ContactList
    /// </summary>
    [SharepointList("Контакты")]
    public partial class ContactList : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for Country:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Country", MapData.LookupId)]
        public int CountryId { get; set; }

        /// <summary> 
        ///lookup values for  Country:Lookup ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Territory CountryLookUp(ISpClient client) => client.GetById<Territory>(CountryId);

        /// <summary>
        ///(Country)Country:Lookup ,  
        /// </summary>
        [SharepointField("Country", MapData.LookupValue)]
        public String Country { get; set; }

        /// <summary>
        ///lookup Id(s) for City:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("City", MapData.LookupId)]
        public int CityId { get; set; }

        /// <summary> 
        ///lookup values for  City:Lookup ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Territory CityLookUp(ISpClient client) => client.GetById<Territory>(CityId);

        /// <summary>
        ///(City)City:Lookup ,  
        /// </summary>
        [SharepointField("City", MapData.LookupValue)]
        public String City { get; set; }

        /// <summary>
        ///(Phone)Phone:Text ,  
        /// </summary>
        [SharepointField("Phone")]
        public String Phone { get; set; }

        /// <summary>
        ///(PhoneMobile)PhoneMobile:Text ,  
        /// </summary>
        [SharepointField("PhoneMobile")]
        public String PhoneMobile { get; set; }

        /// <summary>
        ///(Fax)Fax:Text ,  
        /// </summary>
        [SharepointField("Fax")]
        public String Fax { get; set; }

        /// <summary>
        ///(Email)Email:Text ,  
        /// </summary>
        [SharepointField("Email")]
        public String Email { get; set; }

        /// <summary>
        ///(ZipCode)ZipCode:Text ,  
        /// </summary>
        [SharepointField("ZipCode")]
        public String ZipCode { get; set; }

        /// <summary>
        ///(Comment)Comment:Note ,  
        /// </summary>
        [SharepointField("Comment")]
        public String Comment { get; set; }

        /// <summary>
        ///(IsMainDepartment)IsMainDepartment:Boolean ,  
        /// </summary>
        [SharepointField("IsMainDepartment")]
        public Boolean? IsMainDepartment { get; set; }

        /// <summary>
        ///(IsWarehouse)IsWarehouse:Boolean ,  
        /// </summary>
        [SharepointField("IsWarehouse")]
        public Boolean? IsWarehouse { get; set; }

        /// <summary>
        ///(Order0)Order0:Number ,  
        /// </summary>
        [SharepointField("Order0")]
        public Int32 Order0 { get; set; }

        /// <summary>
        ///(IsRepOffice)IsRepOffice:Boolean ,  
        /// </summary>
        [SharepointField("IsRepOffice")]
        public Boolean? IsRepOffice { get; set; }

        /// <summary>
        ///(Deactivated)Deactivated:Boolean ,  
        /// </summary>
        [SharepointField("Deactivated")]
        public Boolean? Deactivated { get; set; }

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
        public IEnumerable<Territory> TerritoryLookUp(ISpClient client) => TerritoryId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(Territory)Territory:LookupMulti ,  
        /// </summary>
        [SharepointField("Territory", MapData.LookupValue)]
        public List<String> Territory { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Контакты

    /// <summary>
    ///  Контакты локализация 
    ///  
    ///  ContactLocalizedList
    /// </summary>
    [SharepointList("Контакты локализация")]
    public partial class ContactLocalizedList : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for Contact:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Contact", MapData.LookupId)]
        public int ContactId { get; set; }

        /// <summary> 
        ///lookup values for  Contact:Lookup ,   LookUp list ContactList
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContactList ContactLookUp(ISpClient client) => client.GetById<ContactList>(ContactId);

        /// <summary>
        ///(Contact)Contact:Lookup ,  
        /// </summary>
        [SharepointField("Contact", MapData.LookupValue)]
        public String Contact { get; set; }

        /// <summary>
        ///(Address)Address:Note ,  
        /// </summary>
        [SharepointField("Address")]
        public String Address { get; set; }

        /// <summary>
        ///(Comment)Comment:Note ,  
        /// </summary>
        [SharepointField("Comment")]
        public String Comment { get; set; }

        /// <summary>
        ///lookup Id(s) for Language:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Language", MapData.LookupId)]
        public int LanguageId { get; set; }

        /// <summary> 
        ///lookup values for  Language:Lookup ,   LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContentLang LanguageLookUp(ISpClient client) => client.GetById<ContentLang>(LanguageId);

        /// <summary>
        ///(Language)Language:Lookup ,  
        /// </summary>
        [SharepointField("Language", MapData.LookupValue)]
        public String Language { get; set; }

        /// <summary>
        ///(Order0)Order0:Number ,  
        /// </summary>
        [SharepointField("Order0")]
        public Int32 Order0 { get; set; }

        /// <summary>
        ///(Description)Description:Note ,  
        /// </summary>
        [SharepointField("Description")]
        public String Description { get; set; }

        /// <summary>
        ///(DescriptionPlain)DescriptionPlain:Note ,  
        /// </summary>
        [SharepointField("DescriptionPlain")]
        public String DescriptionPlain { get; set; }

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
        public IEnumerable<Territory> TerritoryLookUp(ISpClient client) => TerritoryId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(Territory)Territory:LookupMulti ,  
        /// </summary>
        [SharepointField("Territory", MapData.LookupValue)]
        public List<String> Territory { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Контакты локализация

    /// <summary>
    ///  Контент для повторного использования 
    ///  Элементы этого списка содержат код HTML или текст, который может быть вставлен на веб-страницы. Если для элемента выбрано автоматическое обновление, его контент будет вставляться на веб-страницы как ссылка только для чтения и обновляться по мере изменения элемента. Если автоматическое обновление элемента не выбрано, его контент будет вставляться на веб-страницы как копия и не будет обновляться при изменении элемента.
    ///  ReusableContent
    /// </summary>
    [SharepointList("Контент для повторного использования")]
    public partial class ReusableContent : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Comments)Comments:Note ,  
        /// </summary>
        [SharepointField("Comments")]
        public String Comments { get; set; }

        /// <summary>
        ///(ContentCategory)ContentCategory:Choice ,  
        /// </summary>
        [SharepointField("ContentCategory")]
        public String ContentCategory { get; set; }

        /// <summary>
        ///(AutomaticUpdate)AutomaticUpdate:Boolean , Если этот параметр выбран, контент данного элемента списка будет вставляться на веб-страницы как ссылка только для чтения. Новые версии данного элемента будут отображаться на веб-страницах автоматически. Если параметр не выбран, контент данного элемента списка будет вставляться на веб-страницы как копия, доступная авторам страниц для изменения. Новые версии данного элемента не будут автоматически отображаться на веб-страницах. Любые изменения этого параметра не будут влиять на существующие веб-страницы, использующие данный элемент. 
        /// </summary>
        [SharepointField("AutomaticUpdate")]
        public Boolean? AutomaticUpdate { get; set; }

        /// <summary>
        ///(ShowInRibbon)ShowInRibbon:Boolean , Выберите данный параметр, если необходимо вывести этот повторно используемый элемент контента в раскрывающемся меню, доступном при редактировании страницы. Это позволяет быстро добавлять элементы на странице. 
        /// </summary>
        [SharepointField("ShowInRibbon")]
        public Boolean? ShowInRibbon { get; set; }

        /// <summary>
        ///(ReusableHtml)ReusableHtml:HTML ,  
        /// </summary>
        [SharepointField("ReusableHtml")]
        public String ReusableHtml { get; set; }

        /// <summary>
        ///(ReusableText)ReusableText:Note ,  
        /// </summary>
        [SharepointField("ReusableText")]
        public String ReusableText { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Контент для повторного использования

    /// <summary>
    ///  Логотипы вендоров 
    ///  
    ///  VendorLogos
    /// </summary>
    [SharepointList("Логотипы вендоров")]
    public partial class VendorLogos : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(FileLeafRef)FileLeafRef:File ,  
        /// </summary>
        [SharepointField("FileLeafRef")]
        public String FileLeafRef { get; set; }

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for Vendor:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Vendor", MapData.LookupId)]
        public int VendorId { get; set; }

        /// <summary> 
        ///lookup values for  Vendor:Lookup ,   LookUp list Vendor
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Vendor VendorLookUp(ISpClient client) => client.GetById<Vendor>(VendorId);

        /// <summary>
        ///(Vendor)Vendor:Lookup ,  
        /// </summary>
        [SharepointField("Vendor", MapData.LookupValue)]
        public String Vendor { get; set; }

        /// <summary>
        ///(VendorOnPortal)VendorOnPortal:Boolean ,  
        /// </summary>
        [SharepointField("VendorOnPortal")]
        public Boolean? VendorOnPortal { get; set; }

        /// <summary>
        ///(IsUpToDate)IsUpToDate:Boolean ,  
        /// </summary>
        [SharepointField("IsUpToDate")]
        public Boolean? IsUpToDate { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
        /// </summary>
        [SharepointField("Author", MapData.LookupValue)]
        public String Author { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///lookup Id(s) for Editor:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Editor", MapData.LookupId)]
        public int EditorId { get; set; }

        /// <summary>
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_CopySource)OData__CopySource:Text ,  
        /// </summary>
        [SharepointField("OData__CopySource")]
        public String OData__CopySource { get; set; }

        /// <summary>
        ///lookup Id(s) for CheckoutUser:
        ///User 
        ///  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupId)]
        public int CheckoutUserId { get; set; }

        /// <summary>
        ///(CheckoutUser)CheckoutUser:User ,  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupValue)]
        public String CheckoutUser { get; set; }

        /// <summary>
        ///lookup Id(s) for OData__CheckinComment:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("_CheckinComment", MapData.LookupId)]
        public int _CheckinCommentId { get; set; }

        /// <summary>
        ///(_CheckinComment)OData__CheckinComment:Lookup ,  
        /// </summary>
        [SharepointField("OData__CheckinComment", MapData.LookupValue)]
        public String OData__CheckinComment { get; set; }

        /// <summary>
        ///lookup Id(s) for ItemChildCount:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ItemChildCount", MapData.LookupId)]
        public int ItemChildCountId { get; set; }

        /// <summary>
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentVersionString:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupId)]
        public int ParentVersionStringId { get; set; }

        /// <summary>
        ///(ParentVersionString)ParentVersionString:Lookup ,  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupValue)]
        public String ParentVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentLeafName:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupId)]
        public int ParentLeafNameId { get; set; }

        /// <summary>
        ///(ParentLeafName)ParentLeafName:Lookup ,  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupValue)]
        public String ParentLeafName { get; set; }

    }//Логотипы вендоров

    /// <summary>
    ///  Локализация ресурсов 
    ///  Локализация текстовых ресурсов
    ///  MontResourcesList
    /// </summary>
    [SharepointList("Локализация ресурсов")]
    public partial class MontResourcesList : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(MontResourceValue)MontResourceValue:Note , Как ресурс должен выглядеть для выбранного языка 
        /// </summary>
        [SharepointField("MontResourceValue")]
        public String MontResourceValue { get; set; }

        /// <summary>
        ///(MontResourceDescription)MontResourceDescription:Note , Краткая информация о ресурсе 
        /// </summary>
        [SharepointField("MontResourceDescription")]
        public String MontResourceDescription { get; set; }

        /// <summary>
        ///lookup Id(s) for MontSystems:
        ///LookupMulti 
        ///Системы, использующие данный ресурс  
        /// </summary>
        [SharepointField("MontSystems", MapData.LookupId)]
        public List<int> MontSystemsId { get; set; }

        /// <summary> 
        ///lookup values for  MontSystems:LookupMulti , Системы, использующие данный ресурс  LookUp list MontSystemsList
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<MontSystemsList> MontSystemsLookUp(ISpClient client) => MontSystemsId.Select(l => client.GetById<MontSystemsList>(l));

        /// <summary>
        ///(MontSystems)MontSystems:LookupMulti , Системы, использующие данный ресурс 
        /// </summary>
        [SharepointField("MontSystems", MapData.LookupValue)]
        public List<String> MontSystems { get; set; }

        /// <summary>
        ///lookup Id(s) for MontLanguages:
        ///LookupMulti 
        ///Языки, для которых локализовано значение ресурса  
        /// </summary>
        [SharepointField("MontLanguages", MapData.LookupId)]
        public List<int> MontLanguagesId { get; set; }

        /// <summary> 
        ///lookup values for  MontLanguages:LookupMulti , Языки, для которых локализовано значение ресурса  LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<ContentLang> MontLanguagesLookUp(ISpClient client) => MontLanguagesId.Select(l => client.GetById<ContentLang>(l));

        /// <summary>
        ///(MontLanguages)MontLanguages:LookupMulti , Языки, для которых локализовано значение ресурса 
        /// </summary>
        [SharepointField("MontLanguages", MapData.LookupValue)]
        public List<String> MontLanguages { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Локализация ресурсов

    /// <summary>
    ///  Менеджеры 
    ///  
    ///  List45List
    /// </summary>
    [SharepointList("Менеджеры")]
    public partial class Manager : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(phone)phone:Text , телефон менеджера 
        /// </summary>
        [SharepointField("phone")]
        public String phone { get; set; }

        /// <summary>
        ///(photo)photo:URL , фото менеджера 
        /// </summary>
        [SharepointField("photo")]
        public String photo { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Менеджеры

    /// <summary>
    ///  Менеджеры локализация 
    ///  
    ///  List46List
    /// </summary>
    [SharepointList("Менеджеры локализация")]
    public partial class ManagerLocalization : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for Manager:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Manager", MapData.LookupId)]
        public int ManagerId { get; set; }

        /// <summary> 
        ///lookup values for  Manager:Lookup ,   LookUp list Manager
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Manager ManagerLookUp(ISpClient client) => client.GetById<Manager>(ManagerId);

        /// <summary>
        ///(Manager)Manager:Lookup ,  
        /// </summary>
        [SharepointField("Manager", MapData.LookupValue)]
        public String Manager { get; set; }

        /// <summary>
        ///lookup Id(s) for Lang:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Lang", MapData.LookupId)]
        public int LangId { get; set; }

        /// <summary> 
        ///lookup values for  Lang:Lookup ,   LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContentLang LangLookUp(ISpClient client) => client.GetById<ContentLang>(LangId);

        /// <summary>
        ///(Lang)Lang:Lookup ,  
        /// </summary>
        [SharepointField("Lang", MapData.LookupValue)]
        public String Lang { get; set; }

        /// <summary>
        ///(Fio)Fio:Text ,  
        /// </summary>
        [SharepointField("Fio")]
        public String Fio { get; set; }

        /// <summary>
        ///(position)position:Text ,  
        /// </summary>
        [SharepointField("position")]
        public String position { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Менеджеры локализация

    /// <summary>
    ///  Меню 
    ///  
    ///  List12List
    /// </summary>
    [SharepointList("Меню")]
    public partial class Menu : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(URL)URL:Text ,  
        /// </summary>
        [SharepointField("URL")]
        public String URL { get; set; }

        /// <summary>
        ///(IsMain)IsMain:Boolean ,  
        /// </summary>
        [SharepointField("IsMain")]
        public Boolean? IsMain { get; set; }

        /// <summary>
        ///lookup Id(s) for BusinessType:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("BusinessType", MapData.LookupId)]
        public List<int> BusinessTypeId { get; set; }

        /// <summary> 
        ///lookup values for  BusinessType:LookupMulti ,   LookUp list BusnessType
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<BusnessType> BusinessTypeLookUp(ISpClient client) => BusinessTypeId.Select(l => client.GetById<BusnessType>(l));

        /// <summary>
        ///(BusinessType)BusinessType:LookupMulti ,  
        /// </summary>
        [SharepointField("BusinessType", MapData.LookupValue)]
        public List<String> BusinessType { get; set; }

        /// <summary>
        ///lookup Id(s) for Parent:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Parent", MapData.LookupId)]
        public int ParentId { get; set; }

        /// <summary> 
        ///lookup values for  Parent:Lookup ,   LookUp list Menu
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Menu ParentLookUp(ISpClient client) => client.GetById<Menu>(ParentId);

        /// <summary>
        ///(Parent)Parent:Lookup ,  
        /// </summary>
        [SharepointField("Parent", MapData.LookupValue)]
        public String Parent { get; set; }

        /// <summary>
        ///(isPublic)isPublic:Boolean ,  
        /// </summary>
        [SharepointField("isPublic")]
        public Boolean? isPublic { get; set; }

        /// <summary>
        ///(Order0)Order0:Number ,  
        /// </summary>
        [SharepointField("Order0")]
        public Int32 Order0 { get; set; }

        /// <summary>
        ///lookup Id(s) for Section:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Section", MapData.LookupId)]
        public int SectionId { get; set; }

        /// <summary> 
        ///lookup values for  Section:Lookup ,   LookUp list TextPage
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public TextPage SectionLookUp(ISpClient client) => client.GetById<TextPage>(SectionId);

        /// <summary>
        ///(Section)Section:Lookup ,  
        /// </summary>
        [SharepointField("Section", MapData.LookupValue)]
        public String Section { get; set; }

        /// <summary>
        ///lookup Id(s) for Countries:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("Countries", MapData.LookupId)]
        public List<int> CountriesId { get; set; }

        /// <summary> 
        ///lookup values for  Countries:LookupMulti ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Territory> CountriesLookUp(ISpClient client) => CountriesId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(Countries)Countries:LookupMulti ,  
        /// </summary>
        [SharepointField("Countries", MapData.LookupValue)]
        public List<String> Countries { get; set; }

        /// <summary>
        ///(IsProfileMenu)IsProfileMenu:Boolean ,  
        /// </summary>
        [SharepointField("IsProfileMenu")]
        public Boolean? IsProfileMenu { get; set; }

        /// <summary>
        ///lookup Id(s) for Audience:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("Audience", MapData.LookupId)]
        public List<int> AudienceId { get; set; }

        /// <summary> 
        ///lookup values for  Audience:LookupMulti ,   LookUp list Audience
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Audience> AudienceLookUp(ISpClient client) => AudienceId.Select(l => client.GetById<Audience>(l));

        /// <summary>
        ///(Audience)Audience:LookupMulti ,  
        /// </summary>
        [SharepointField("Audience", MapData.LookupValue)]
        public List<String> Audience { get; set; }

        /// <summary>
        ///lookup Id(s) for MenuType:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MenuType", MapData.LookupId)]
        public int MenuTypeId { get; set; }

        /// <summary> 
        ///lookup values for  MenuType:Lookup ,   LookUp list MenuTypeList
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public MenuTypeList MenuTypeLookUp(ISpClient client) => client.GetById<MenuTypeList>(MenuTypeId);

        /// <summary>
        ///(MenuType)MenuType:Lookup ,  
        /// </summary>
        [SharepointField("MenuType", MapData.LookupValue)]
        public String MenuType { get; set; }

        /// <summary>
        ///(IsDeactivated)IsDeactivated:Boolean ,  
        /// </summary>
        [SharepointField("IsDeactivated")]
        public Boolean? IsDeactivated { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Меню

    /// <summary>
    ///  Меню локализация 
    ///  
    ///  List38List
    /// </summary>
    [SharepointList("Меню локализация")]
    public partial class MenuLocalization : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for Language:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Language", MapData.LookupId)]
        public int LanguageId { get; set; }

        /// <summary> 
        ///lookup values for  Language:Lookup ,   LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContentLang LanguageLookUp(ISpClient client) => client.GetById<ContentLang>(LanguageId);

        /// <summary>
        ///(Language)Language:Lookup ,  
        /// </summary>
        [SharepointField("Language", MapData.LookupValue)]
        public String Language { get; set; }

        /// <summary>
        ///lookup Id(s) for Menu:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("Menu", MapData.LookupId)]
        public List<int> MenuId { get; set; }

        /// <summary> 
        ///lookup values for  Menu:LookupMulti ,   LookUp list Menu
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Menu> MenuLookUp(ISpClient client) => MenuId.Select(l => client.GetById<Menu>(l));

        /// <summary>
        ///(Menu)Menu:LookupMulti ,  
        /// </summary>
        [SharepointField("Menu", MapData.LookupValue)]
        public List<String> Menu { get; set; }

        /// <summary>
        ///lookup Id(s) for Territories:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("Territories", MapData.LookupId)]
        public List<int> TerritoriesId { get; set; }

        /// <summary> 
        ///lookup values for  Territories:LookupMulti ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Territory> TerritoriesLookUp(ISpClient client) => TerritoriesId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(Territories)Territories:LookupMulti ,  
        /// </summary>
        [SharepointField("Territories", MapData.LookupValue)]
        public List<String> Territories { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Меню локализация

    /// <summary>
    ///  Микроканал 
    ///  Список постоянного хранения для микроканала на личном сайте
    ///  PublishedFeedList
    /// </summary>
    [SharepointList("Микроканал")]
    public partial class PublishedFeedList : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(MicroBlogType)MicroBlogType:Integer ,  
        /// </summary>
        [SharepointField("MicroBlogType")]
        public String MicroBlogType { get; set; }

        /// <summary>
        ///(PostAuthor)PostAuthor:Text ,  
        /// </summary>
        [SharepointField("PostAuthor")]
        public String PostAuthor { get; set; }

        /// <summary>
        ///(DefinitionId)DefinitionId:Integer ,  
        /// </summary>
        [SharepointField("DefinitionId")]
        public String DefinitionId { get; set; }

        /// <summary>
        ///(RootPostID)RootPostID:Integer ,  
        /// </summary>
        [SharepointField("RootPostID")]
        public String RootPostID { get; set; }

        /// <summary>
        ///(RootPostOwnerID)RootPostOwnerID:Text ,  
        /// </summary>
        [SharepointField("RootPostOwnerID")]
        public String RootPostOwnerID { get; set; }

        /// <summary>
        ///(RootPostUniqueID)RootPostUniqueID:Text ,  
        /// </summary>
        [SharepointField("RootPostUniqueID")]
        public String RootPostUniqueID { get; set; }

        /// <summary>
        ///(ReplyCount)ReplyCount:Integer ,  
        /// </summary>
        [SharepointField("ReplyCount")]
        public String ReplyCount { get; set; }

        /// <summary>
        ///(ReferenceID)ReferenceID:Text ,  
        /// </summary>
        [SharepointField("ReferenceID")]
        public String ReferenceID { get; set; }

        /// <summary>
        ///(Attributes)Attributes:Integer ,  
        /// </summary>
        [SharepointField("Attributes")]
        public String Attributes { get; set; }

        /// <summary>
        ///(Content)Content:Note ,  
        /// </summary>
        [SharepointField("Content")]
        public String Content { get; set; }

        /// <summary>
        ///(ContentData)ContentData:Note ,  
        /// </summary>
        [SharepointField("ContentData")]
        public String ContentData { get; set; }

        /// <summary>
        ///(SearchContent)SearchContent:Note ,  
        /// </summary>
        [SharepointField("SearchContent")]
        public String SearchContent { get; set; }

        /// <summary>
        ///(RefRoot)RefRoot:Note ,  
        /// </summary>
        [SharepointField("RefRoot")]
        public String RefRoot { get; set; }

        /// <summary>
        ///(RefReply)RefReply:Note ,  
        /// </summary>
        [SharepointField("RefReply")]
        public String RefReply { get; set; }

        /// <summary>
        ///(PostSource)PostSource:Text ,  
        /// </summary>
        [SharepointField("PostSource")]
        public String PostSource { get; set; }

        /// <summary>
        ///(PeopleCount)PeopleCount:Integer ,  
        /// </summary>
        [SharepointField("PeopleCount")]
        public String PeopleCount { get; set; }

        /// <summary>
        ///(PeopleList)PeopleList:Note ,  
        /// </summary>
        [SharepointField("PeopleList")]
        public String PeopleList { get; set; }

        /// <summary>
        ///(MediaLinkType)MediaLinkType:Integer ,  
        /// </summary>
        [SharepointField("MediaLinkType")]
        public String MediaLinkType { get; set; }

        /// <summary>
        ///(MediaLinkDescription)MediaLinkDescription:Text ,  
        /// </summary>
        [SharepointField("MediaLinkDescription")]
        public String MediaLinkDescription { get; set; }

        /// <summary>
        ///(PostSourceUri)PostSourceUri:Note ,  
        /// </summary>
        [SharepointField("PostSourceUri")]
        public String PostSourceUri { get; set; }

        /// <summary>
        ///(MediaLinkURI)MediaLinkURI:URL ,  
        /// </summary>
        [SharepointField("MediaLinkURI")]
        public String MediaLinkURI { get; set; }

        /// <summary>
        ///(MediaLinkUISnippet)MediaLinkUISnippet:URL ,  
        /// </summary>
        [SharepointField("MediaLinkUISnippet")]
        public String MediaLinkUISnippet { get; set; }

        /// <summary>
        ///(MediaLinkContentURI)MediaLinkContentURI:URL ,  
        /// </summary>
        [SharepointField("MediaLinkContentURI")]
        public String MediaLinkContentURI { get; set; }

        /// <summary>
        ///(MediaLength)MediaLength:Integer ,  
        /// </summary>
        [SharepointField("MediaLength")]
        public String MediaLength { get; set; }

        /// <summary>
        ///(MediaWidth)MediaWidth:Integer ,  
        /// </summary>
        [SharepointField("MediaWidth")]
        public String MediaWidth { get; set; }

        /// <summary>
        ///(MediaHeight)MediaHeight:Integer ,  
        /// </summary>
        [SharepointField("MediaHeight")]
        public String MediaHeight { get; set; }

        /// <summary>
        ///(MediaActionClickUrl)MediaActionClickUrl:URL ,  
        /// </summary>
        [SharepointField("MediaActionClickUrl")]
        public String MediaActionClickUrl { get; set; }

        /// <summary>
        ///(MediaActionClickKind)MediaActionClickKind:Integer ,  
        /// </summary>
        [SharepointField("MediaActionClickKind")]
        public String MediaActionClickKind { get; set; }

        /// <summary>
        ///(eMailSubscribers)eMailSubscribers:Note ,  
        /// </summary>
        [SharepointField("eMailSubscribers")]
        public String eMailSubscribers { get; set; }

        /// <summary>
        ///(eMailUnsubscribed)eMailUnsubscribed:Note ,  
        /// </summary>
        [SharepointField("eMailUnsubscribed")]
        public String eMailUnsubscribed { get; set; }

        /// <summary>
        ///(RemoteLocation)RemoteLocation:Note ,  
        /// </summary>
        [SharepointField("RemoteLocation")]
        public String RemoteLocation { get; set; }

        /// <summary>
        ///(LikesCount)LikesCount:Likes ,  
        /// </summary>
        [SharepointField("LikesCount")]
        public String LikesCount { get; set; }

        /// <summary>
        ///(HashTags)HashTags:TaxonomyFieldTypeMulti , Some description 
        /// </summary>
        [SharepointField("HashTags")]
        public String HashTags { get; set; }

        /// <summary>
        ///(MediaPreviewWidth)MediaPreviewWidth:Integer ,  
        /// </summary>
        [SharepointField("MediaPreviewWidth")]
        public String MediaPreviewWidth { get; set; }

        /// <summary>
        ///(MediaPreviewHeight)MediaPreviewHeight:Integer ,  
        /// </summary>
        [SharepointField("MediaPreviewHeight")]
        public String MediaPreviewHeight { get; set; }

        /// <summary>
        ///(MediaActionWidth)MediaActionWidth:Integer ,  
        /// </summary>
        [SharepointField("MediaActionWidth")]
        public String MediaActionWidth { get; set; }

        /// <summary>
        ///(MediaActionHeight)MediaActionHeight:Integer ,  
        /// </summary>
        [SharepointField("MediaActionHeight")]
        public String MediaActionHeight { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Микроканал

    /// <summary>
    ///  Модель данных 
    ///  Информация о текущей модели данных
    ///  ModelInfoList
    /// </summary>
    [SharepointList("Модель данных")]
    public partial class ModelInfoList : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(MontDescription)MontDescription:Note , Описание модели 
        /// </summary>
        [SharepointField("MontDescription")]
        public String MontDescription { get; set; }

        /// <summary>
        ///(MontUpgradeLog)MontUpgradeLog:Note , Лог апгрэйда БД 
        /// </summary>
        [SharepointField("MontUpgradeLog")]
        public String MontUpgradeLog { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Модель данных

    /// <summary>
    ///  Направления Бизнеса 
    ///  
    ///  List10List
    /// </summary>
    [SharepointList("Направления Бизнеса")]
    public partial class BusnessType : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(ImgUrl)ImgUrl:Text , Картинка направления 
        /// </summary>
        [SharepointField("ImgUrl")]
        public String ImgUrl { get; set; }

        /// <summary>
        ///(Url)Url:Text ,  
        /// </summary>
        [SharepointField("Url")]
        public String Url { get; set; }

        /// <summary>
        ///lookup Id(s) for contacts:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("contacts", MapData.LookupId)]
        public int contactsId { get; set; }

        /// <summary> 
        ///lookup values for  contacts:Lookup ,   LookUp list Manager
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Manager contactsLookUp(ISpClient client) => client.GetById<Manager>(contactsId);

        /// <summary>
        ///(contacts)contacts:Lookup ,  
        /// </summary>
        [SharepointField("contacts", MapData.LookupValue)]
        public String contacts { get; set; }

        /// <summary>
        ///(Description)Description:Text ,  
        /// </summary>
        [SharepointField("Description")]
        public String Description { get; set; }

        /// <summary>
        ///(Order0)Order0:Number ,  
        /// </summary>
        [SharepointField("Order0")]
        public Int32 Order0 { get; set; }

        /// <summary>
        ///lookup Id(s) for Menu:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Menu", MapData.LookupId)]
        public int MenuId { get; set; }

        /// <summary> 
        ///lookup values for  Menu:Lookup ,   LookUp list Menu
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Menu MenuLookUp(ISpClient client) => client.GetById<Menu>(MenuId);

        /// <summary>
        ///(Menu)Menu:Lookup ,  
        /// </summary>
        [SharepointField("Menu", MapData.LookupValue)]
        public String Menu { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Направления Бизнеса

    /// <summary>
    ///  Направления Бизнеса локализованные 
    ///  
    ///  List29List
    /// </summary>
    [SharepointList("Направления Бизнеса локализованные")]
    public partial class BusnessTypeLocalization : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentBisLine:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentBisLine", MapData.LookupId)]
        public int ParentBisLineId { get; set; }

        /// <summary> 
        ///lookup values for  ParentBisLine:Lookup ,   LookUp list BusnessType
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public BusnessType ParentBisLineLookUp(ISpClient client) => client.GetById<BusnessType>(ParentBisLineId);

        /// <summary>
        ///(ParentBisLine)ParentBisLine:Lookup ,  
        /// </summary>
        [SharepointField("ParentBisLine", MapData.LookupValue)]
        public String ParentBisLine { get; set; }

        /// <summary>
        ///(ContactInfo)ContactInfo:Note ,  
        /// </summary>
        [SharepointField("ContactInfo")]
        public String ContactInfo { get; set; }

        /// <summary>
        ///lookup Id(s) for Language:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Language", MapData.LookupId)]
        public int LanguageId { get; set; }

        /// <summary> 
        ///lookup values for  Language:Lookup ,   LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContentLang LanguageLookUp(ISpClient client) => client.GetById<ContentLang>(LanguageId);

        /// <summary>
        ///(Language)Language:Lookup ,  
        /// </summary>
        [SharepointField("Language", MapData.LookupValue)]
        public String Language { get; set; }

        /// <summary>
        ///(DescriptionLineBusiness)DescriptionLineBusiness:Note ,  
        /// </summary>
        [SharepointField("DescriptionLineBusiness")]
        public String DescriptionLineBusiness { get; set; }

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
        public IEnumerable<Territory> TerritoryLookUp(ISpClient client) => TerritoryId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(Territory)Territory:LookupMulti ,  
        /// </summary>
        [SharepointField("Territory", MapData.LookupValue)]
        public List<String> Territory { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Направления Бизнеса локализованные

    /// <summary>
    ///  Настройки 
    ///  
    ///  List44List
    /// </summary>
    [SharepointList("Настройки")]
    public partial class Setting : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(MontValue)MontValue:Note ,  
        /// </summary>
        [SharepointField("MontValue")]
        public String MontValue { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Настройки

    /// <summary>
    ///  Настройки уведомлений 
    ///  
    ///  ListList
    /// </summary>
    [SharepointList("Настройки уведомлений")]
    public partial class NotificationSetting : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Emails)Emails:Note ,  
        /// </summary>
        [SharepointField("Emails")]
        public String Emails { get; set; }

        /// <summary>
        ///(Subj)Subj:Text ,  
        /// </summary>
        [SharepointField("Subj")]
        public String Subj { get; set; }

        /// <summary>
        ///(Body)Body:Note ,  
        /// </summary>
        [SharepointField("Body")]
        public String Body { get; set; }

        /// <summary>
        ///(NotifyEditor)NotifyEditor:Boolean ,  
        /// </summary>
        [SharepointField("NotifyEditor")]
        public Boolean? NotifyEditor { get; set; }

        /// <summary>
        ///(NotifyInitiator)NotifyInitiator:Boolean ,  
        /// </summary>
        [SharepointField("NotifyInitiator")]
        public Boolean? NotifyInitiator { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Настройки уведомлений

    /// <summary>
    ///  Отчеты о контенте и структуре 
    ///  Список отчетов служит для настройки запросов, отображаемых в представлениях инструмента "Контент и структура"
    ///  Reports_x0020_List
    /// </summary>
    [SharepointList("Отчеты о контенте и структуре")]
    public partial class Reports_x0020_List : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(_x0024_Resources_x003a_cmscore_x)OData__x0024_Resources_x003a_cmscore_x:Text ,  
        /// </summary>
        [SharepointField("OData__x0024_Resources_x003a_cmscore_x")]
        public String OData__x0024_Resources_x003a_cmscore_x { get; set; }

        /// <summary>
        ///(_x0024_Resources_x003a_cmscore_x0)OData__x0024_Resources_x003a_cmscore_x0:Text ,  
        /// </summary>
        [SharepointField("OData__x0024_Resources_x003a_cmscore_x0")]
        public String OData__x0024_Resources_x003a_cmscore_x0 { get; set; }

        /// <summary>
        ///(_x0024_Resources_x003a_cmscore_x1)OData__x0024_Resources_x003a_cmscore_x1:Text , Введите имя шаблона списка для типа списка CAML или оставьте поле пустым, чтобы найти шаблон в библиотеке документов 
        /// </summary>
        [SharepointField("OData__x0024_Resources_x003a_cmscore_x1")]
        public String OData__x0024_Resources_x003a_cmscore_x1 { get; set; }

        /// <summary>
        ///(_x0024_Resources_x003a_cmscore_x2)OData__x0024_Resources_x003a_cmscore_x2:Text , Введите разметку CAML для запроса отчета 
        /// </summary>
        [SharepointField("OData__x0024_Resources_x003a_cmscore_x2")]
        public String OData__x0024_Resources_x003a_cmscore_x2 { get; set; }

        /// <summary>
        ///(_x0426__x0435__x043b__x0435__x04)OData__x0426__x0435__x043b__x0435__x04:TargetTo ,  
        /// </summary>
        [SharepointField("OData__x0426__x0435__x043b__x0435__x04")]
        public String OData__x0426__x0435__x043b__x0435__x04 { get; set; }

        /// <summary>
        ///(_x041e__x043f__x0438__x0441__x04)OData__x041e__x043f__x0438__x0441__x04:Text ,  
        /// </summary>
        [SharepointField("OData__x041e__x043f__x0438__x0441__x04")]
        public String OData__x041e__x043f__x0438__x0441__x04 { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Отчеты о контенте и структуре

    /// <summary>
    ///  Права пользователей 
    ///  Список, содержащий права пользователей в разных территориях
    ///  List17List
    /// </summary>
    [SharepointList("Права пользователей")]
    public partial class List17List : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

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
        public IEnumerable<Territory> MontTerritoriesLookUp(ISpClient client) => MontTerritoriesId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(MontTerritories)MontTerritories:LookupMulti ,  
        /// </summary>
        [SharepointField("MontTerritories", MapData.LookupValue)]
        public List<String> MontTerritories { get; set; }

        /// <summary>
        ///lookup Id(s) for MontRoles:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("MontRoles", MapData.LookupId)]
        public List<int> MontRolesId { get; set; }

        /// <summary> 
        ///lookup values for  MontRoles:LookupMulti ,   LookUp list Role
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Role> MontRolesLookUp(ISpClient client) => MontRolesId.Select(l => client.GetById<Role>(l));

        /// <summary>
        ///(MontRoles)MontRoles:LookupMulti ,  
        /// </summary>
        [SharepointField("MontRoles", MapData.LookupValue)]
        public List<String> MontRoles { get; set; }

        /// <summary>
        ///lookup Id(s) for Users:
        ///UserMulti 
        ///  
        /// </summary>
        [SharepointField("Users", MapData.LookupId)]
        public List<int> UsersId { get; set; }

        /// <summary>
        ///(Users)Users:UserMulti ,  
        /// </summary>
        [SharepointField("Users", MapData.LookupValue)]
        public List<String> Users { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Права пользователей

    /// <summary>
    ///  Ресурсы 
    ///  
    ///  List37List
    /// </summary>
    [SharepointList("Ресурсы")]
    public partial class Resource : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Controller)Controller:Text ,  
        /// </summary>
        [SharepointField("Controller")]
        public String Controller { get; set; }

        /// <summary>
        ///(Action)Action:Text ,  
        /// </summary>
        [SharepointField("Action")]
        public String Action { get; set; }

        /// <summary>
        ///(Area)Area:Text ,  
        /// </summary>
        [SharepointField("Area")]
        public String Area { get; set; }

        /// <summary>
        ///lookup Id(s) for Menu:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Menu", MapData.LookupId)]
        public int MenuId { get; set; }

        /// <summary> 
        ///lookup values for  Menu:Lookup ,   LookUp list Menu
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Menu MenuLookUp(ISpClient client) => client.GetById<Menu>(MenuId);

        /// <summary>
        ///(Menu)Menu:Lookup ,  
        /// </summary>
        [SharepointField("Menu", MapData.LookupValue)]
        public String Menu { get; set; }

        /// <summary>
        ///lookup Id(s) for Audience:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("Audience", MapData.LookupId)]
        public List<int> AudienceId { get; set; }

        /// <summary> 
        ///lookup values for  Audience:LookupMulti ,   LookUp list Audience
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Audience> AudienceLookUp(ISpClient client) => AudienceId.Select(l => client.GetById<Audience>(l));

        /// <summary>
        ///(Audience)Audience:LookupMulti ,  
        /// </summary>
        [SharepointField("Audience", MapData.LookupValue)]
        public List<String> Audience { get; set; }

        /// <summary>
        ///lookup Id(s) for Param:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Param", MapData.LookupId)]
        public int ParamId { get; set; }

        /// <summary> 
        ///lookup values for  Param:Lookup ,   LookUp list TextPage
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public TextPage ParamLookUp(ISpClient client) => client.GetById<TextPage>(ParamId);

        /// <summary>
        ///(Param)Param:Lookup ,  
        /// </summary>
        [SharepointField("Param", MapData.LookupValue)]
        public String Param { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Ресурсы

    /// <summary>
    ///  Решения 
    ///  
    ///  List41List
    /// </summary>
    [SharepointList("Решения")]
    public partial class Decisions : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Image)Image:URL ,  
        /// </summary>
        [SharepointField("Image")]
        public String Image { get; set; }

        /// <summary>
        ///lookup Id(s) for Vendor:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Vendor", MapData.LookupId)]
        public int VendorId { get; set; }

        /// <summary> 
        ///lookup values for  Vendor:Lookup ,   LookUp list Vendor
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Vendor VendorLookUp(ISpClient client) => client.GetById<Vendor>(VendorId);

        /// <summary>
        ///(Vendor)Vendor:Lookup ,  
        /// </summary>
        [SharepointField("Vendor", MapData.LookupValue)]
        public String Vendor { get; set; }

        /// <summary>
        ///(IsPublic)IsPublic:Boolean ,  
        /// </summary>
        [SharepointField("IsPublic")]
        public Boolean? IsPublic { get; set; }

        /// <summary>
        ///lookup Id(s) for Email:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Email", MapData.LookupId)]
        public int EmailId { get; set; }

        /// <summary>
        ///(Email)Email:User ,  
        /// </summary>
        [SharepointField("Email", MapData.LookupValue)]
        public String Email { get; set; }

        /// <summary>
        ///lookup Id(s) for Category:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Category", MapData.LookupId)]
        public int CategoryId { get; set; }

        /// <summary> 
        ///lookup values for  Category:Lookup ,   LookUp list Category
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Category CategoryLookUp(ISpClient client) => client.GetById<Category>(CategoryId);

        /// <summary>
        ///(Category)Category:Lookup ,  
        /// </summary>
        [SharepointField("Category", MapData.LookupValue)]
        public String Category { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Решения

    /// <summary>
    ///  Решения локализация 
    ///  
    ///  List42List
    /// </summary>
    [SharepointList("Решения локализация")]
    public partial class DecisionsLocalization : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Announce)Announce:Note ,  
        /// </summary>
        [SharepointField("Announce")]
        public String Announce { get; set; }

        /// <summary>
        ///(Description)Description:Note ,  
        /// </summary>
        [SharepointField("Description")]
        public String Description { get; set; }

        /// <summary>
        ///(Requirements)Requirements:Note ,  
        /// </summary>
        [SharepointField("Requirements")]
        public String Requirements { get; set; }

        /// <summary>
        ///(Link)Link:URL ,  
        /// </summary>
        [SharepointField("Link")]
        public String Link { get; set; }

        /// <summary>
        ///lookup Id(s) for Language:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Language", MapData.LookupId)]
        public int LanguageId { get; set; }

        /// <summary> 
        ///lookup values for  Language:Lookup ,   LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContentLang LanguageLookUp(ISpClient client) => client.GetById<ContentLang>(LanguageId);

        /// <summary>
        ///(Language)Language:Lookup ,  
        /// </summary>
        [SharepointField("Language", MapData.LookupValue)]
        public String Language { get; set; }

        /// <summary>
        ///lookup Id(s) for Solution:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Solution", MapData.LookupId)]
        public int SolutionId { get; set; }

        /// <summary> 
        ///lookup values for  Solution:Lookup ,   LookUp list Decisions
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Decisions SolutionLookUp(ISpClient client) => client.GetById<Decisions>(SolutionId);

        /// <summary>
        ///(Solution)Solution:Lookup ,  
        /// </summary>
        [SharepointField("Solution", MapData.LookupValue)]
        public String Solution { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Решения локализация

    /// <summary>
    ///  Роли 
    ///  Список ролей публикации контента
    ///  List16List
    /// </summary>
    [SharepointList("Роли")]
    public partial class Role : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Роли

    /// <summary>
    ///  Системы 
    ///  Справочник систем МОНТ, получающих информацию с данного сайта (портал, CRM и т.д.)
    ///  MontSystemsList
    /// </summary>
    [SharepointList("Системы")]
    public partial class MontSystemsList : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(MontDescription)MontDescription:Note , Краткая информация о системе 
        /// </summary>
        [SharepointField("MontDescription")]
        public String MontDescription { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Системы

    /// <summary>
    ///  Содержание акций 
    ///  
    ///  List25List
    /// </summary>
    [SharepointList("Содержание акций")]
    public partial class PromotionContent : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(MontNewsPreview)MontNewsPreview:Note ,  
        /// </summary>
        [SharepointField("MontNewsPreview")]
        public String MontNewsPreview { get; set; }

        /// <summary>
        ///lookup Id(s) for MontPromoId:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontPromoId", MapData.LookupId)]
        public int MontPromoIdId { get; set; }

        /// <summary> 
        ///lookup values for  MontPromoId:Lookup ,   LookUp list Promotion
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Promotion MontPromoIdLookUp(ISpClient client) => client.GetById<Promotion>(MontPromoIdId);

        /// <summary>
        ///(MontPromoId)MontPromoId:Lookup ,  
        /// </summary>
        [SharepointField("MontPromoId", MapData.LookupValue)]
        public String MontPromoId { get; set; }

        /// <summary>
        ///(MontPromoBody)MontPromoBody:Note ,  
        /// </summary>
        [SharepointField("MontPromoBody")]
        public String MontPromoBody { get; set; }

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
        public ContentLang MontLanguageLookUp(ISpClient client) => client.GetById<ContentLang>(MontLanguageId);

        /// <summary>
        ///(MontLanguage)MontLanguage:Lookup ,  
        /// </summary>
        [SharepointField("MontLanguage", MapData.LookupValue)]
        public String MontLanguage { get; set; }

        /// <summary>
        ///(MontNewsTags)MontNewsTags:Text ,  
        /// </summary>
        [SharepointField("MontNewsTags")]
        public String MontNewsTags { get; set; }

        /// <summary>
        ///(MontContentBody)MontContentBody:Note ,  
        /// </summary>
        [SharepointField("MontContentBody")]
        public String MontContentBody { get; set; }

        /// <summary>
        ///(MontContentPreview)MontContentPreview:Note ,  
        /// </summary>
        [SharepointField("MontContentPreview")]
        public String MontContentPreview { get; set; }

        /// <summary>
        ///(OldPortalEventId)OldPortalEventId:Text ,  
        /// </summary>
        [SharepointField("OldPortalEventId")]
        public String OldPortalEventId { get; set; }

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
        public IEnumerable<Territory> TerritoryLookUp(ISpClient client) => TerritoryId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(Territory)Territory:LookupMulti ,  
        /// </summary>
        [SharepointField("Territory", MapData.LookupValue)]
        public List<String> Territory { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Содержание акций

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
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(MontNewsPreview)MontNewsPreview:Note ,  
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
        public Event MontEventIdLookUp(ISpClient client) => client.GetById<Event>(MontEventIdId);

        /// <summary>
        ///(MontEventId)MontEventId:Lookup ,  
        /// </summary>
        [SharepointField("MontEventId", MapData.LookupValue)]
        public String MontEventId { get; set; }

        /// <summary>
        ///(MontNewsTags)MontNewsTags:Text ,  
        /// </summary>
        [SharepointField("MontNewsTags")]
        public String MontNewsTags { get; set; }

        /// <summary>
        ///(MontEventBody)MontEventBody:Note ,  
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
        public ContentLang MontLanguageLookUp(ISpClient client) => client.GetById<ContentLang>(MontLanguageId);

        /// <summary>
        ///(MontLanguage)MontLanguage:Lookup ,  
        /// </summary>
        [SharepointField("MontLanguage", MapData.LookupValue)]
        public String MontLanguage { get; set; }

        /// <summary>
        ///(MontContentBody)MontContentBody:Note ,  
        /// </summary>
        [SharepointField("MontContentBody")]
        public String MontContentBody { get; set; }

        /// <summary>
        ///(MontContentPreview)MontContentPreview:Note ,  
        /// </summary>
        [SharepointField("MontContentPreview")]
        public String MontContentPreview { get; set; }

        /// <summary>
        ///(OldPortalEventId)OldPortalEventId:Text ,  
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
        public IEnumerable<Territory> MontTerritoriesLookUp(ISpClient client) => MontTerritoriesId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(MontTerritories)MontTerritories:LookupMulti ,  
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
        public IEnumerable<Territory> TerritoryLookUp(ISpClient client) => TerritoryId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(Territory)Territory:LookupMulti ,  
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

        /// <summary> 
        ///lookup values for  MontBlocks:LookupMulti , Блоки с контентом данного мероприятия  LookUp list EventBlocksList
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<EventBlocksList> MontBlocksLookUp(ISpClient client) => MontBlocksId.Select(l => client.GetById<EventBlocksList>(l));

        /// <summary>
        ///(MontBlocks)MontBlocks:LookupMulti , Блоки с контентом данного мероприятия 
        /// </summary>
        [SharepointField("MontBlocks", MapData.LookupValue)]
        public List<String> MontBlocks { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Содержание мероприятий

    /// <summary>
    ///  Содержание новостей 
    ///  Список содержит контент новости из списка "Список новостей" на конкретном языке.
    ///  List8List
    /// </summary>
    [SharepointList("Содержание новостей")]
    public partial class NewsContent : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for MontNewsList:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontNewsList", MapData.LookupId)]
        public int MontNewsListId { get; set; }

        /// <summary> 
        ///lookup values for  MontNewsList:Lookup ,   LookUp list News
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public News MontNewsListLookUp(ISpClient client) => client.GetById<News>(MontNewsListId);

        /// <summary>
        ///(MontNewsList)MontNewsList:Lookup ,  
        /// </summary>
        [SharepointField("MontNewsList", MapData.LookupValue)]
        public String MontNewsList { get; set; }

        /// <summary>
        ///lookup Id(s) for MontLang:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontLang", MapData.LookupId)]
        public int MontLangId { get; set; }

        /// <summary> 
        ///lookup values for  MontLang:Lookup ,   LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContentLang MontLangLookUp(ISpClient client) => client.GetById<ContentLang>(MontLangId);

        /// <summary>
        ///(MontLang)MontLang:Lookup ,  
        /// </summary>
        [SharepointField("MontLang", MapData.LookupValue)]
        public String MontLang { get; set; }

        /// <summary>
        ///(MontNewsPreview)MontNewsPreview:Note ,  
        /// </summary>
        [SharepointField("MontNewsPreview")]
        public String MontNewsPreview { get; set; }

        /// <summary>
        ///(MontNewsBody)MontNewsBody:Note ,  
        /// </summary>
        [SharepointField("MontNewsBody")]
        public String MontNewsBody { get; set; }

        /// <summary>
        ///(MontNewsTags)MontNewsTags:Text ,  
        /// </summary>
        [SharepointField("MontNewsTags")]
        public String MontNewsTags { get; set; }

        /// <summary>
        ///(MontContentBody)MontContentBody:Note ,  
        /// </summary>
        [SharepointField("MontContentBody")]
        public String MontContentBody { get; set; }

        /// <summary>
        ///(MontContentPreview)MontContentPreview:Note ,  
        /// </summary>
        [SharepointField("MontContentPreview")]
        public String MontContentPreview { get; set; }

        /// <summary>
        ///(OldPortalEventId)OldPortalEventId:Text ,  
        /// </summary>
        [SharepointField("OldPortalEventId")]
        public String OldPortalEventId { get; set; }

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
        public IEnumerable<Territory> TerritoryLookUp(ISpClient client) => TerritoryId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(Territory)Territory:LookupMulti ,  
        /// </summary>
        [SharepointField("Territory", MapData.LookupValue)]
        public List<String> Territory { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Содержание новостей

    /// <summary>
    ///  Сообщения - Связаться с нами 
    ///  
    ///  List43List
    /// </summary>
    [SharepointList("Сообщения - Связаться с нами")]
    public partial class LinkWithUs : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Name)Name:Text ,  
        /// </summary>
        [SharepointField("Name")]
        public String Name { get; set; }

        /// <summary>
        ///(Sender)Sender:Text ,  
        /// </summary>
        [SharepointField("Sender")]
        public String Sender { get; set; }

        /// <summary>
        ///(Recipient)Recipient:Text ,  
        /// </summary>
        [SharepointField("Recipient")]
        public String Recipient { get; set; }

        /// <summary>
        ///(Message)Message:Note ,  
        /// </summary>
        [SharepointField("Message")]
        public String Message { get; set; }

        /// <summary>
        ///(Phone)Phone:Text ,  
        /// </summary>
        [SharepointField("Phone")]
        public String Phone { get; set; }

        /// <summary>
        ///(Login)Login:Text ,  
        /// </summary>
        [SharepointField("Login")]
        public String Login { get; set; }

        /// <summary>
        ///(AxCode)AxCode:Text ,  
        /// </summary>
        [SharepointField("AxCode")]
        public String AxCode { get; set; }

        /// <summary>
        ///(IsSent)IsSent:Boolean ,  
        /// </summary>
        [SharepointField("IsSent")]
        public Boolean? IsSent { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Сообщения - Связаться с нами

    /// <summary>
    ///  Список акций 
    ///  
    ///  List24List
    /// </summary>
    [SharepointList("Список акций")]
    public partial class Promotion : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for MontAudience:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontAudience", MapData.LookupId)]
        public int MontAudienceId { get; set; }

        /// <summary> 
        ///lookup values for  MontAudience:Lookup ,   LookUp list Audience
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Audience MontAudienceLookUp(ISpClient client) => client.GetById<Audience>(MontAudienceId);

        /// <summary>
        ///(MontAudience)MontAudience:Lookup ,  
        /// </summary>
        [SharepointField("MontAudience", MapData.LookupValue)]
        public String MontAudience { get; set; }

        /// <summary>
        ///lookup Id(s) for MontVendors:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("MontVendors", MapData.LookupId)]
        public List<int> MontVendorsId { get; set; }

        /// <summary> 
        ///lookup values for  MontVendors:LookupMulti ,   LookUp list Vendor
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Vendor> MontVendorsLookUp(ISpClient client) => MontVendorsId.Select(l => client.GetById<Vendor>(l));

        /// <summary>
        ///(MontVendors)MontVendors:LookupMulti ,  
        /// </summary>
        [SharepointField("MontVendors", MapData.LookupValue)]
        public List<String> MontVendors { get; set; }

        /// <summary>
        ///(MontEventStarts)MontEventStarts:DateTime ,  
        /// </summary>
        [SharepointField("MontEventStarts")]
        public DateTime? MontEventStarts { get; set; }

        /// <summary>
        ///(MontPromoPublishingStarts)MontPromoPublishingStarts:DateTime ,  
        /// </summary>
        [SharepointField("MontPromoPublishingStarts")]
        public DateTime MontPromoPublishingStarts { get; set; }

        /// <summary>
        ///(MontPromoEnds)MontPromoEnds:DateTime ,  
        /// </summary>
        [SharepointField("MontPromoEnds")]
        public DateTime? MontPromoEnds { get; set; }

        /// <summary>
        ///(MontPromoPublishingEnds)MontPromoPublishingEnds:DateTime ,  
        /// </summary>
        [SharepointField("MontPromoPublishingEnds")]
        public DateTime MontPromoPublishingEnds { get; set; }

        /// <summary>
        ///lookup Id(s) for MontEventBusinessLines:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("MontEventBusinessLines", MapData.LookupId)]
        public List<int> MontEventBusinessLinesId { get; set; }

        /// <summary> 
        ///lookup values for  MontEventBusinessLines:LookupMulti ,   LookUp list BusnessType
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<BusnessType> MontEventBusinessLinesLookUp(ISpClient client) => MontEventBusinessLinesId.Select(l => client.GetById<BusnessType>(l));

        /// <summary>
        ///(MontEventBusinessLines)MontEventBusinessLines:LookupMulti ,  
        /// </summary>
        [SharepointField("MontEventBusinessLines", MapData.LookupValue)]
        public List<String> MontEventBusinessLines { get; set; }

        /// <summary>
        ///(MontNewsTags)MontNewsTags:Text ,  
        /// </summary>
        [SharepointField("MontNewsTags")]
        public String MontNewsTags { get; set; }

        /// <summary>
        ///lookup Id(s) for MontNewsPublishingStatus:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontNewsPublishingStatus", MapData.LookupId)]
        public int MontNewsPublishingStatusId { get; set; }

        /// <summary> 
        ///lookup values for  MontNewsPublishingStatus:Lookup ,   LookUp list PublishStatus
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public PublishStatus MontNewsPublishingStatusLookUp(ISpClient client) => client.GetById<PublishStatus>(MontNewsPublishingStatusId);

        /// <summary>
        ///(MontNewsPublishingStatus)MontNewsPublishingStatus:Lookup ,  
        /// </summary>
        [SharepointField("MontNewsPublishingStatus", MapData.LookupValue)]
        public String MontNewsPublishingStatus { get; set; }

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
        public IEnumerable<Territory> MontTerritoriesLookUp(ISpClient client) => MontTerritoriesId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(MontTerritories)MontTerritories:LookupMulti ,  
        /// </summary>
        [SharepointField("MontTerritories", MapData.LookupValue)]
        public List<String> MontTerritories { get; set; }

        /// <summary>
        ///(MontEventAnouncementImg)MontEventAnouncementImg:URL ,  
        /// </summary>
        [SharepointField("MontEventAnouncementImg")]
        public String MontEventAnouncementImg { get; set; }

        /// <summary>
        ///lookup Id(s) for Responsible:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Responsible", MapData.LookupId)]
        public int ResponsibleId { get; set; }

        /// <summary>
        ///(Responsible)Responsible:User ,  
        /// </summary>
        [SharepointField("Responsible", MapData.LookupValue)]
        public String Responsible { get; set; }

        /// <summary>
        ///(StatusChanged)StatusChanged:Boolean ,  
        /// </summary>
        [SharepointField("StatusChanged")]
        public Boolean? StatusChanged { get; set; }

        /// <summary>
        ///(AttachmentsInfo)AttachmentsInfo:Note ,  
        /// </summary>
        [SharepointField("AttachmentsInfo")]
        public String AttachmentsInfo { get; set; }

        /// <summary>
        ///(OldPortalEventId)OldPortalEventId:Number ,  
        /// </summary>
        [SharepointField("OldPortalEventId")]
        public Int32? OldPortalEventId { get; set; }

        /// <summary>
        ///(PromoType)PromoType:Number ,  
        /// </summary>
        [SharepointField("PromoType")]
        public Int32? PromoType { get; set; }

        /// <summary>
        ///(InternalComment)InternalComment:Note ,  
        /// </summary>
        [SharepointField("InternalComment")]
        public String InternalComment { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Список акций

    /// <summary>
    ///  Список мероприятий 
    ///  
    ///  List26List
    /// </summary>
    [SharepointList("Список мероприятий")]
    public partial class Event : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for MontAudience:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontAudience", MapData.LookupId)]
        public int MontAudienceId { get; set; }

        /// <summary> 
        ///lookup values for  MontAudience:Lookup ,   LookUp list Audience
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Audience MontAudienceLookUp(ISpClient client) => client.GetById<Audience>(MontAudienceId);

        /// <summary>
        ///(MontAudience)MontAudience:Lookup ,  
        /// </summary>
        [SharepointField("MontAudience", MapData.LookupValue)]
        public String MontAudience { get; set; }

        /// <summary>
        ///lookup Id(s) for MontVendors:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("MontVendors", MapData.LookupId)]
        public List<int> MontVendorsId { get; set; }

        /// <summary> 
        ///lookup values for  MontVendors:LookupMulti ,   LookUp list Vendor
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Vendor> MontVendorsLookUp(ISpClient client) => MontVendorsId.Select(l => client.GetById<Vendor>(l));

        /// <summary>
        ///(MontVendors)MontVendors:LookupMulti ,  
        /// </summary>
        [SharepointField("MontVendors", MapData.LookupValue)]
        public List<String> MontVendors { get; set; }

        /// <summary>
        ///(MontEventPublishingStarts)MontEventPublishingStarts:DateTime ,  
        /// </summary>
        [SharepointField("MontEventPublishingStarts")]
        public DateTime MontEventPublishingStarts { get; set; }

        /// <summary>
        ///(MontPromoPublishingEnds)MontPromoPublishingEnds:DateTime ,  
        /// </summary>
        [SharepointField("MontPromoPublishingEnds")]
        public DateTime MontPromoPublishingEnds { get; set; }

        /// <summary>
        ///lookup Id(s) for MontEventBusinessLines:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("MontEventBusinessLines", MapData.LookupId)]
        public List<int> MontEventBusinessLinesId { get; set; }

        /// <summary> 
        ///lookup values for  MontEventBusinessLines:LookupMulti ,   LookUp list BusnessType
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<BusnessType> MontEventBusinessLinesLookUp(ISpClient client) => MontEventBusinessLinesId.Select(l => client.GetById<BusnessType>(l));

        /// <summary>
        ///(MontEventBusinessLines)MontEventBusinessLines:LookupMulti ,  
        /// </summary>
        [SharepointField("MontEventBusinessLines", MapData.LookupValue)]
        public List<String> MontEventBusinessLines { get; set; }

        /// <summary>
        ///(MontNewsTags)MontNewsTags:Text ,  
        /// </summary>
        [SharepointField("MontNewsTags")]
        public String MontNewsTags { get; set; }

        /// <summary>
        ///lookup Id(s) for MontNewsPublishingStatus:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontNewsPublishingStatus", MapData.LookupId)]
        public int MontNewsPublishingStatusId { get; set; }

        /// <summary> 
        ///lookup values for  MontNewsPublishingStatus:Lookup ,   LookUp list PublishStatus
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public PublishStatus MontNewsPublishingStatusLookUp(ISpClient client) => client.GetById<PublishStatus>(MontNewsPublishingStatusId);

        /// <summary>
        ///(MontNewsPublishingStatus)MontNewsPublishingStatus:Lookup ,  
        /// </summary>
        [SharepointField("MontNewsPublishingStatus", MapData.LookupValue)]
        public String MontNewsPublishingStatus { get; set; }

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
        public IEnumerable<Territory> MontTerritoriesLookUp(ISpClient client) => MontTerritoriesId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(MontTerritories)MontTerritories:LookupMulti ,  
        /// </summary>
        [SharepointField("MontTerritories", MapData.LookupValue)]
        public List<String> MontTerritories { get; set; }

        /// <summary>
        ///lookup Id(s) for MontEventEventType:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontEventEventType", MapData.LookupId)]
        public int MontEventEventTypeId { get; set; }

        /// <summary> 
        ///lookup values for  MontEventEventType:Lookup ,   LookUp list EventType
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public EventType MontEventEventTypeLookUp(ISpClient client) => client.GetById<EventType>(MontEventEventTypeId);

        /// <summary>
        ///(MontEventEventType)MontEventEventType:Lookup ,  
        /// </summary>
        [SharepointField("MontEventEventType", MapData.LookupValue)]
        public String MontEventEventType { get; set; }

        /// <summary>
        ///(MontEventRegOnSite)MontEventRegOnSite:Boolean ,  
        /// </summary>
        [SharepointField("MontEventRegOnSite")]
        public Boolean? MontEventRegOnSite { get; set; }

        /// <summary>
        ///(MontEventAnouncementImg)MontEventAnouncementImg:URL ,  
        /// </summary>
        [SharepointField("MontEventAnouncementImg")]
        public String MontEventAnouncementImg { get; set; }

        /// <summary>
        ///(MontCrmEventTitle)MontCrmEventTitle:Text ,  
        /// </summary>
        [SharepointField("MontCrmEventTitle")]
        public String MontCrmEventTitle { get; set; }

        /// <summary>
        ///(MontCrmEventBody)MontCrmEventBody:Note ,  
        /// </summary>
        [SharepointField("MontCrmEventBody")]
        public String MontCrmEventBody { get; set; }

        /// <summary>
        ///(MontCrmEventPreview)MontCrmEventPreview:Note ,  
        /// </summary>
        [SharepointField("MontCrmEventPreview")]
        public String MontCrmEventPreview { get; set; }

        /// <summary>
        ///(MontIsCanceled)MontIsCanceled:Boolean , Да - мероприятие было отменено 
        /// </summary>
        [SharepointField("MontIsCanceled")]
        public Boolean? MontIsCanceled { get; set; }

        /// <summary>
        ///(MontCrmEventChanges)MontCrmEventChanges:Note ,  
        /// </summary>
        [SharepointField("MontCrmEventChanges")]
        public String MontCrmEventChanges { get; set; }

        /// <summary>
        ///(MontFirstEventStarts)MontFirstEventStarts:DateTime ,  
        /// </summary>
        [SharepointField("MontFirstEventStarts")]
        public DateTime? MontFirstEventStarts { get; set; }

        /// <summary>
        ///(MontLastEventEnds)MontLastEventEnds:DateTime ,  
        /// </summary>
        [SharepointField("MontLastEventEnds")]
        public DateTime? MontLastEventEnds { get; set; }

        /// <summary>
        ///lookup Id(s) for MontEventCities:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("MontEventCities", MapData.LookupId)]
        public List<int> MontEventCitiesId { get; set; }

        /// <summary> 
        ///lookup values for  MontEventCities:LookupMulti ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Territory> MontEventCitiesLookUp(ISpClient client) => MontEventCitiesId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(MontEventCities)MontEventCities:LookupMulti ,  
        /// </summary>
        [SharepointField("MontEventCities", MapData.LookupValue)]
        public List<String> MontEventCities { get; set; }

        /// <summary>
        ///(OldPortalEventId)OldPortalEventId:Number ,  
        /// </summary>
        [SharepointField("OldPortalEventId")]
        public Int32? OldPortalEventId { get; set; }

        /// <summary>
        ///(AttachmentsInfo)AttachmentsInfo:Note ,  
        /// </summary>
        [SharepointField("AttachmentsInfo")]
        public String AttachmentsInfo { get; set; }

        /// <summary>
        ///lookup Id(s) for Responsible:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Responsible", MapData.LookupId)]
        public int ResponsibleId { get; set; }

        /// <summary>
        ///(Responsible)Responsible:User ,  
        /// </summary>
        [SharepointField("Responsible", MapData.LookupValue)]
        public String Responsible { get; set; }

        /// <summary>
        ///(StatusChanged)StatusChanged:Boolean ,  
        /// </summary>
        [SharepointField("StatusChanged")]
        public Boolean? StatusChanged { get; set; }

        /// <summary>
        ///(InternalComment)InternalComment:Note ,  
        /// </summary>
        [SharepointField("InternalComment")]
        public String InternalComment { get; set; }

        /// <summary>
        ///lookup Id(s) for Initiator:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Initiator", MapData.LookupId)]
        public int InitiatorId { get; set; }

        /// <summary>
        ///(Initiator)Initiator:User ,  
        /// </summary>
        [SharepointField("Initiator", MapData.LookupValue)]
        public String Initiator { get; set; }

        /// <summary>
        ///lookup Id(s) for MontTerritory:
        ///Lookup 
        ///Город проведения мероприятия  
        /// </summary>
        [SharepointField("MontTerritory", MapData.LookupId)]
        public int MontTerritoryId { get; set; }

        /// <summary> 
        ///lookup values for  MontTerritory:Lookup , Город проведения мероприятия  LookUp list Territory
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Territory MontTerritoryLookUp(ISpClient client) => client.GetById<Territory>(MontTerritoryId);

        /// <summary>
        ///(MontTerritory)MontTerritory:Lookup , Город проведения мероприятия 
        /// </summary>
        [SharepointField("MontTerritory", MapData.LookupValue)]
        public String MontTerritory { get; set; }

        /// <summary>
        ///(MontEventStarts)MontEventStarts:DateTime , Начало мероприятия в локальном времени города проведения 
        /// </summary>
        [SharepointField("MontEventStarts")]
        public DateTime? MontEventStarts { get; set; }

        /// <summary>
        ///(MontEventEnds)MontEventEnds:DateTime , Окончание мероприятия в локальном времени города проведения 
        /// </summary>
        [SharepointField("MontEventEnds")]
        public DateTime? MontEventEnds { get; set; }

        /// <summary>
        ///(MontRegStarts)MontRegStarts:DateTime , Начало регистрации в локальном времени города проведения 
        /// </summary>
        [SharepointField("MontRegStarts")]
        public DateTime? MontRegStarts { get; set; }

        /// <summary>
        ///(MontRegEnds)MontRegEnds:DateTime , Окончание регистрации в локальном времени города проведения 
        /// </summary>
        [SharepointField("MontRegEnds")]
        public DateTime? MontRegEnds { get; set; }

        /// <summary>
        ///(MontEventImg)MontEventImg:URL , Ссылка на картинку, которая будет отображаться в заголовке новости (не в анонсе) 
        /// </summary>
        [SharepointField("MontEventImg")]
        public String MontEventImg { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Список мероприятий

    /// <summary>
    ///  Список новостей 
    ///  Список содержит список новостей. Контент каждой новости из списка находится в списке "Содержание новостей"
    ///  List7List
    /// </summary>
    [SharepointList("Список новостей")]
    public partial class News : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(MontNewsPublishingStarts)MontNewsPublishingStarts:DateTime ,  
        /// </summary>
        [SharepointField("MontNewsPublishingStarts")]
        public DateTime MontNewsPublishingStarts { get; set; }

        /// <summary>
        ///(MontNewsPublishingEnds)MontNewsPublishingEnds:DateTime ,  
        /// </summary>
        [SharepointField("MontNewsPublishingEnds")]
        public DateTime MontNewsPublishingEnds { get; set; }

        /// <summary>
        ///lookup Id(s) for MontNewsPublishingStatus:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontNewsPublishingStatus", MapData.LookupId)]
        public int MontNewsPublishingStatusId { get; set; }

        /// <summary> 
        ///lookup values for  MontNewsPublishingStatus:Lookup ,   LookUp list PublishStatus
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public PublishStatus MontNewsPublishingStatusLookUp(ISpClient client) => client.GetById<PublishStatus>(MontNewsPublishingStatusId);

        /// <summary>
        ///(MontNewsPublishingStatus)MontNewsPublishingStatus:Lookup ,  
        /// </summary>
        [SharepointField("MontNewsPublishingStatus", MapData.LookupValue)]
        public String MontNewsPublishingStatus { get; set; }

        /// <summary>
        ///lookup Id(s) for MontAudience:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontAudience", MapData.LookupId)]
        public int MontAudienceId { get; set; }

        /// <summary> 
        ///lookup values for  MontAudience:Lookup ,   LookUp list Audience
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Audience MontAudienceLookUp(ISpClient client) => client.GetById<Audience>(MontAudienceId);

        /// <summary>
        ///(MontAudience)MontAudience:Lookup ,  
        /// </summary>
        [SharepointField("MontAudience", MapData.LookupValue)]
        public String MontAudience { get; set; }

        /// <summary>
        ///(MontNewsTags)MontNewsTags:Text ,  
        /// </summary>
        [SharepointField("MontNewsTags")]
        public String MontNewsTags { get; set; }

        /// <summary>
        ///lookup Id(s) for MontVendors:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("MontVendors", MapData.LookupId)]
        public List<int> MontVendorsId { get; set; }

        /// <summary> 
        ///lookup values for  MontVendors:LookupMulti ,   LookUp list Vendor
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Vendor> MontVendorsLookUp(ISpClient client) => MontVendorsId.Select(l => client.GetById<Vendor>(l));

        /// <summary>
        ///(MontVendors)MontVendors:LookupMulti ,  
        /// </summary>
        [SharepointField("MontVendors", MapData.LookupValue)]
        public List<String> MontVendors { get; set; }

        /// <summary>
        ///(MontNewsIsPromoted)MontNewsIsPromoted:Boolean ,  
        /// </summary>
        [SharepointField("MontNewsIsPromoted")]
        public Boolean? MontNewsIsPromoted { get; set; }

        /// <summary>
        ///lookup Id(s) for Business:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("Business", MapData.LookupId)]
        public List<int> BusinessId { get; set; }

        /// <summary> 
        ///lookup values for  Business:LookupMulti ,   LookUp list BusnessType
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<BusnessType> BusinessLookUp(ISpClient client) => BusinessId.Select(l => client.GetById<BusnessType>(l));

        /// <summary>
        ///(Business)Business:LookupMulti ,  
        /// </summary>
        [SharepointField("Business", MapData.LookupValue)]
        public List<String> Business { get; set; }

        /// <summary>
        ///(ImageUrl)ImageUrl:URL ,  
        /// </summary>
        [SharepointField("ImageUrl")]
        public String ImageUrl { get; set; }

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
        public IEnumerable<Territory> TerritoryLookUp(ISpClient client) => TerritoryId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(Territory)Territory:LookupMulti ,  
        /// </summary>
        [SharepointField("Territory", MapData.LookupValue)]
        public List<String> Territory { get; set; }

        /// <summary>
        ///lookup Id(s) for Responsible:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Responsible", MapData.LookupId)]
        public int ResponsibleId { get; set; }

        /// <summary>
        ///(Responsible)Responsible:User ,  
        /// </summary>
        [SharepointField("Responsible", MapData.LookupValue)]
        public String Responsible { get; set; }

        /// <summary>
        ///(StatusChanged)StatusChanged:Boolean ,  
        /// </summary>
        [SharepointField("StatusChanged")]
        public Boolean? StatusChanged { get; set; }

        /// <summary>
        ///(AttachmentsInfo)AttachmentsInfo:Note ,  
        /// </summary>
        [SharepointField("AttachmentsInfo")]
        public String AttachmentsInfo { get; set; }

        /// <summary>
        ///(OldPortalEventId)OldPortalEventId:Number ,  
        /// </summary>
        [SharepointField("OldPortalEventId")]
        public Int32? OldPortalEventId { get; set; }

        /// <summary>
        ///(InternalComment)InternalComment:Note ,  
        /// </summary>
        [SharepointField("InternalComment")]
        public String InternalComment { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Список новостей

    /// <summary>
    ///  Список сообщений 
    ///  
    ///  List9List
    /// </summary>
    [SharepointList("Список сообщений")]
    public partial class Notification : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for Tags:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("Tags", MapData.LookupId)]
        public List<int> TagsId { get; set; }

        /// <summary>
        ///(Tags)Tags:LookupMulti ,  
        /// </summary>
        [SharepointField("Tags", MapData.LookupValue)]
        public List<String> Tags { get; set; }

        /// <summary>
        ///(Subject)Subject:Note ,  
        /// </summary>
        [SharepointField("Subject")]
        public String Subject { get; set; }

        /// <summary>
        ///(Preview)Preview:Note ,  
        /// </summary>
        [SharepointField("Preview")]
        public String Preview { get; set; }

        /// <summary>
        ///(Body)Body:Note ,  
        /// </summary>
        [SharepointField("Body")]
        public String Body { get; set; }

        /// <summary>
        ///(OfferEnds)OfferEnds:DateTime ,  
        /// </summary>
        [SharepointField("OfferEnds")]
        public DateTime? OfferEnds { get; set; }

        /// <summary>
        ///(OfferStarts)OfferStarts:DateTime ,  
        /// </summary>
        [SharepointField("OfferStarts")]
        public DateTime? OfferStarts { get; set; }

        /// <summary>
        ///lookup Id(s) for Vendors:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("Vendors", MapData.LookupId)]
        public List<int> VendorsId { get; set; }

        /// <summary> 
        ///lookup values for  Vendors:LookupMulti ,   LookUp list Vendor
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Vendor> VendorsLookUp(ISpClient client) => VendorsId.Select(l => client.GetById<Vendor>(l));

        /// <summary>
        ///(Vendors)Vendors:LookupMulti ,  
        /// </summary>
        [SharepointField("Vendors", MapData.LookupValue)]
        public List<String> Vendors { get; set; }

        /// <summary>
        ///lookup Id(s) for From:
        ///User 
        ///  
        /// </summary>
        [SharepointField("From", MapData.LookupId)]
        public int FromId { get; set; }

        /// <summary>
        ///(From)From:User ,  
        /// </summary>
        [SharepointField("From", MapData.LookupValue)]
        public String From { get; set; }

        /// <summary>
        ///(Importance)Importance:Text ,  
        /// </summary>
        [SharepointField("Importance")]
        public String Importance { get; set; }

        /// <summary>
        ///(ThreadTopic)ThreadTopic:Text ,  
        /// </summary>
        [SharepointField("ThreadTopic")]
        public String ThreadTopic { get; set; }

        /// <summary>
        ///(ThreadIndex)ThreadIndex:Text ,  
        /// </summary>
        [SharepointField("ThreadIndex")]
        public String ThreadIndex { get; set; }

        /// <summary>
        ///(MailSubject)MailSubject:Note ,  
        /// </summary>
        [SharepointField("MailSubject")]
        public String MailSubject { get; set; }

        /// <summary>
        ///(MailBody)MailBody:Note ,  
        /// </summary>
        [SharepointField("MailBody")]
        public String MailBody { get; set; }

        /// <summary>
        ///(Status)Status:Text ,  
        /// </summary>
        [SharepointField("Status")]
        public String Status { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Список сообщений

    /// <summary>
    ///  Статус мероприятия 
    ///  
    ///  List31List
    /// </summary>
    [SharepointList("Статус мероприятия")]
    public partial class EventStatus : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Статус мероприятия

    /// <summary>
    ///  Статус мероприятия локализация 
    ///  
    ///  List32List
    /// </summary>
    [SharepointList("Статус мероприятия локализация")]
    public partial class EventStatusLocalization : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for EventStatus:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("EventStatus", MapData.LookupId)]
        public int EventStatusId { get; set; }

        /// <summary> 
        ///lookup values for  EventStatus:Lookup ,   LookUp list EventStatus
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public EventStatus EventStatusLookUp(ISpClient client) => client.GetById<EventStatus>(EventStatusId);

        /// <summary>
        ///(EventStatus)EventStatus:Lookup ,  
        /// </summary>
        [SharepointField("EventStatus", MapData.LookupValue)]
        public String EventStatus { get; set; }

        /// <summary>
        ///lookup Id(s) for Language:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Language", MapData.LookupId)]
        public int LanguageId { get; set; }

        /// <summary> 
        ///lookup values for  Language:Lookup ,   LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContentLang LanguageLookUp(ISpClient client) => client.GetById<ContentLang>(LanguageId);

        /// <summary>
        ///(Language)Language:Lookup ,  
        /// </summary>
        [SharepointField("Language", MapData.LookupValue)]
        public String Language { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Статус мероприятия локализация

    /// <summary>
    ///  Статусы публикации 
    ///  Список содержит возможные статусы публикации. Например, такие как "Черновик", "На рассмотрении редактора" и т.д.
    ///  List1List
    /// </summary>
    [SharepointList("Статусы публикации")]
    public partial class PublishStatus : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(InternalState)InternalState:Number ,  
        /// </summary>
        [SharepointField("InternalState")]
        public Int32? InternalState { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Статусы публикации

    /// <summary>
    ///  Страница вендора 
    ///  Список страниц. Каждая страница, которую видит пользователь в страницах вендоров представляет собой разные элементы в этом списке. Элементы этого списка связывают вендора, локаль и пункт меню с самой страницей. В каждый конкретный момент времени только одна страница этого списка, связанная с конкретным пунктом меню может быть опубликована. Ее и должен показывать пользователю портал. Может быть такое, что нет опубликованных страниц. Тогда, разумеется, пункт показывать не надо. При этом должна быть возможность просмотра любой из страниц по ссылке для превью.
    ///  VendorPageList
    /// </summary>
    [SharepointList("Страница вендора")]
    public partial class VendorPageList : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(MontVersion)MontVersion:Text ,  
        /// </summary>
        [SharepointField("MontVersion")]
        public String MontVersion { get; set; }

        /// <summary>
        ///lookup Id(s) for MontStatus:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontStatus", MapData.LookupId)]
        public int MontStatusId { get; set; }

        /// <summary> 
        ///lookup values for  MontStatus:Lookup ,   LookUp list PublishStatus
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public PublishStatus MontStatusLookUp(ISpClient client) => client.GetById<PublishStatus>(MontStatusId);

        /// <summary>
        ///(MontStatus)MontStatus:Lookup ,  
        /// </summary>
        [SharepointField("MontStatus", MapData.LookupValue)]
        public String MontStatus { get; set; }

        /// <summary>
        ///lookup Id(s) for MontVendor:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontVendor", MapData.LookupId)]
        public int MontVendorId { get; set; }

        /// <summary> 
        ///lookup values for  MontVendor:Lookup ,   LookUp list Vendor
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Vendor MontVendorLookUp(ISpClient client) => client.GetById<Vendor>(MontVendorId);

        /// <summary>
        ///(MontVendor)MontVendor:Lookup ,  
        /// </summary>
        [SharepointField("MontVendor", MapData.LookupValue)]
        public String MontVendor { get; set; }

        /// <summary>
        ///lookup Id(s) for MontCheckedOutTo:
        ///User 
        ///  
        /// </summary>
        [SharepointField("MontCheckedOutTo", MapData.LookupId)]
        public int MontCheckedOutToId { get; set; }

        /// <summary>
        ///(MontCheckedOutTo)MontCheckedOutTo:User ,  
        /// </summary>
        [SharepointField("MontCheckedOutTo", MapData.LookupValue)]
        public String MontCheckedOutTo { get; set; }

        /// <summary>
        ///lookup Id(s) for MontMenu:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontMenu", MapData.LookupId)]
        public int MontMenuId { get; set; }

        /// <summary> 
        ///lookup values for  MontMenu:Lookup ,   LookUp list Menu
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Menu MontMenuLookUp(ISpClient client) => client.GetById<Menu>(MontMenuId);

        /// <summary>
        ///(MontMenu)MontMenu:Lookup ,  
        /// </summary>
        [SharepointField("MontMenu", MapData.LookupValue)]
        public String MontMenu { get; set; }

        /// <summary>
        ///(MontKeyWords)MontKeyWords:Note ,  
        /// </summary>
        [SharepointField("MontKeyWords")]
        public String MontKeyWords { get; set; }

        /// <summary>
        ///(MontSeoDescription)MontSeoDescription:Note ,  
        /// </summary>
        [SharepointField("MontSeoDescription")]
        public String MontSeoDescription { get; set; }

        /// <summary>
        ///(MontSeoTitle)MontSeoTitle:Note ,  
        /// </summary>
        [SharepointField("MontSeoTitle")]
        public String MontSeoTitle { get; set; }

        /// <summary>
        ///lookup Id(s) for MontTerritory:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("MontTerritory", MapData.LookupId)]
        public List<int> MontTerritoryId { get; set; }

        /// <summary> 
        ///lookup values for  MontTerritory:LookupMulti ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Territory> MontTerritoryLookUp(ISpClient client) => MontTerritoryId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(MontTerritory)MontTerritory:LookupMulti ,  
        /// </summary>
        [SharepointField("MontTerritory", MapData.LookupValue)]
        public List<String> MontTerritory { get; set; }

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
        public ContentLang MontLanguageLookUp(ISpClient client) => client.GetById<ContentLang>(MontLanguageId);

        /// <summary>
        ///(MontLanguage)MontLanguage:Lookup ,  
        /// </summary>
        [SharepointField("MontLanguage", MapData.LookupValue)]
        public String MontLanguage { get; set; }

        /// <summary>
        ///lookup Id(s) for MontVendorPageBlocks:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("MontVendorPageBlocks", MapData.LookupId)]
        public List<int> MontVendorPageBlocksId { get; set; }

        /// <summary> 
        ///lookup values for  MontVendorPageBlocks:LookupMulti ,   LookUp list VendorPageBlockList
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<VendorPageBlockList> MontVendorPageBlocksLookUp(ISpClient client) => MontVendorPageBlocksId.Select(l => client.GetById<VendorPageBlockList>(l));

        /// <summary>
        ///(MontVendorPageBlocks)MontVendorPageBlocks:LookupMulti ,  
        /// </summary>
        [SharepointField("MontVendorPageBlocks", MapData.LookupValue)]
        public List<String> MontVendorPageBlocks { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Страница вендора

    /// <summary>
    ///  Страницы 
    ///  Эта системная библиотека была создана средством публикации для хранения страниц, созданных на данном сайте.
    ///  Pages
    /// </summary>
    [SharepointList("Страницы")]
    public partial class Pages : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(FileLeafRef)FileLeafRef:File ,  
        /// </summary>
        [SharepointField("FileLeafRef")]
        public String FileLeafRef { get; set; }

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Comments)Comments:Note ,  
        /// </summary>
        [SharepointField("Comments")]
        public String Comments { get; set; }

        /// <summary>
        ///lookup Id(s) for PublishingContact:
        ///User 
        ///"Контакт" — это столбец сайта, созданный средством публикации. Он используется в типе контента страницы для указания контактного лица или группы.  
        /// </summary>
        [SharepointField("PublishingContact", MapData.LookupId)]
        public int PublishingContactId { get; set; }

        /// <summary>
        ///(PublishingContact)PublishingContact:User , "Контакт" — это столбец сайта, созданный средством публикации. Он используется в типе контента страницы для указания контактного лица или группы. 
        /// </summary>
        [SharepointField("PublishingContact", MapData.LookupValue)]
        public String PublishingContact { get; set; }

        /// <summary>
        ///(PublishingContactEmail)PublishingContactEmail:Text , "Адрес эл. почты контактного лица" — это столбец сайта, созданный средством публикации. Он используется в типе контента страницы для указания адреса электронной почты контактного лица или группы. 
        /// </summary>
        [SharepointField("PublishingContactEmail")]
        public String PublishingContactEmail { get; set; }

        /// <summary>
        ///(PublishingContactName)PublishingContactName:Text , "Имя контактного лица" — это столбец сайта, созданный средством публикации. Он используется в типа контента страницы для указания имени контактного лица или группы. 
        /// </summary>
        [SharepointField("PublishingContactName")]
        public String PublishingContactName { get; set; }

        /// <summary>
        ///(PublishingContactPicture)PublishingContactPicture:URL , "Картинка контакта" — это столбец сайта, созданный средством публикации. Он используется в типе контента страницы для размещения картинки контактного лица или группы. 
        /// </summary>
        [SharepointField("PublishingContactPicture")]
        public String PublishingContactPicture { get; set; }

        /// <summary>
        ///(PublishingPageLayout)PublishingPageLayout:URL ,  
        /// </summary>
        [SharepointField("PublishingPageLayout")]
        public String PublishingPageLayout { get; set; }

        /// <summary>
        ///(PublishingRollupImage)PublishingRollupImage:Image , "Сводное изображение" — это столбец сайта, созданный средством публикации. Он используется в типе контента страницы для размещения изображения страницы, показанной в свертках контента, например в веб-части "Контент по поиску". 
        /// </summary>
        [SharepointField("PublishingRollupImage")]
        public String PublishingRollupImage { get; set; }

        /// <summary>
        ///(Audience)Audience:TargetTo , "Целевые аудитории" — это столбец сайта, созданный средством публикации. Он используется для указания аудиторий, для которых предназначена данная страница. 
        /// </summary>
        [SharepointField("Audience")]
        public String Audience { get; set; }

        /// <summary>
        ///(PublishingIsFurlPage)PublishingIsFurlPage:Boolean , Если этот флажок установлен, физический URL-адрес этой страницы не отображается в результатах поиска. Полнотекстовый URL-адрес, назначенный этой странице, отображается всегда. 
        /// </summary>
        [SharepointField("PublishingIsFurlPage")]
        public Boolean? PublishingIsFurlPage { get; set; }

        /// <summary>
        ///(SeoBrowserTitle)SeoBrowserTitle:Text , Заголовок обозревателя — это столбец сайта, созданный средством публикации. Он отображается вверху окна браузера и может отображаться в результатах поиска в Интернете. 
        /// </summary>
        [SharepointField("SeoBrowserTitle")]
        public String SeoBrowserTitle { get; set; }

        /// <summary>
        ///(SeoMetaDescription)SeoMetaDescription:Text , META с атрибутом Description — это столбец сайта, созданный средством публикации. Поисковые системы в Интернете могут отображать это описание на страницах результатов поиска. 
        /// </summary>
        [SharepointField("SeoMetaDescription")]
        public String SeoMetaDescription { get; set; }

        /// <summary>
        ///(SeoKeywords)SeoKeywords:Text , META с атрибутом Keywords 
        /// </summary>
        [SharepointField("SeoKeywords")]
        public String SeoKeywords { get; set; }

        /// <summary>
        ///(SeoRobotsNoIndex)RobotsNoIndex:Boolean , "Скрыть от поисковых систем в Интернете" — это столбец сайта, созданный средством публикации. Он показывает программам-обходчикам поисковых систем, что данная конкретная страница не должна индексироваться. 
        /// </summary>
        [SharepointField("RobotsNoIndex")]
        public Boolean? RobotsNoIndex { get; set; }

        /// <summary>
        ///(PublishingPageImage)PublishingPageImage:Image , "Изображение страницы" — это столбец сайта, созданный средством публикации. Он используется в типе контента "Страница статьи" для размещения основного изображения страницы. 
        /// </summary>
        [SharepointField("PublishingPageImage")]
        public String PublishingPageImage { get; set; }

        /// <summary>
        ///(PublishingPageContent)PublishingPageContent:HTML , "Контент страницы" — это столбец сайта, созданный средством публикации. Он используется в типе контента "Страница статьи" для размещения контента страницы. 
        /// </summary>
        [SharepointField("PublishingPageContent")]
        public String PublishingPageContent { get; set; }

        /// <summary>
        ///(SummaryLinks)SummaryLinks:SummaryLinks , "Сводные ссылки" — это столбец сайта, созданный средством публикации. Он используется в типе контента "Страница приветствия" для отображения набора ссылок. 
        /// </summary>
        [SharepointField("SummaryLinks")]
        public String SummaryLinks { get; set; }

        /// <summary>
        ///(ArticleByLine)ArticleByLine:Text , "Автор" — это столбец сайта, созданный средством публикации. Он используется в типе контента "Страница статьи" для указания автора страницы. 
        /// </summary>
        [SharepointField("ArticleByLine")]
        public String ArticleByLine { get; set; }

        /// <summary>
        ///(ArticleStartDate)ArticleStartDate:DateTime , "Дата статьи" — это столбец сайта, созданный средством публикации. Он используется в типе контента "Страница статьи" для указания даты страницы. 
        /// </summary>
        [SharepointField("ArticleStartDate")]
        public DateTime? ArticleStartDate { get; set; }

        /// <summary>
        ///(PublishingImageCaption)PublishingImageCaption:HTML , "Подпись изображения" — это столбец сайта, созданный средством публикации. Он используется в типе контента "Страница статьи" для указания подписи к основному изображению на странице. 
        /// </summary>
        [SharepointField("PublishingImageCaption")]
        public String PublishingImageCaption { get; set; }

        /// <summary>
        ///(SummaryLinks2)SummaryLinks2:SummaryLinks , "Сводные ссылки 2" — это столбец сайта, созданный средством публикации. Он используется в типе контента "Страница приветствия" для отображения второго набора ссылок. 
        /// </summary>
        [SharepointField("SummaryLinks2")]
        public String SummaryLinks2 { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
        /// </summary>
        [SharepointField("Author", MapData.LookupValue)]
        public String Author { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///lookup Id(s) for Editor:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Editor", MapData.LookupId)]
        public int EditorId { get; set; }

        /// <summary>
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_CopySource)OData__CopySource:Text ,  
        /// </summary>
        [SharepointField("OData__CopySource")]
        public String OData__CopySource { get; set; }

        /// <summary>
        ///lookup Id(s) for CheckoutUser:
        ///User 
        ///  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupId)]
        public int CheckoutUserId { get; set; }

        /// <summary>
        ///(CheckoutUser)CheckoutUser:User ,  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupValue)]
        public String CheckoutUser { get; set; }

        /// <summary>
        ///lookup Id(s) for OData__CheckinComment:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("_CheckinComment", MapData.LookupId)]
        public int _CheckinCommentId { get; set; }

        /// <summary>
        ///(_CheckinComment)OData__CheckinComment:Lookup ,  
        /// </summary>
        [SharepointField("OData__CheckinComment", MapData.LookupValue)]
        public String OData__CheckinComment { get; set; }

        /// <summary>
        ///lookup Id(s) for ItemChildCount:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ItemChildCount", MapData.LookupId)]
        public int ItemChildCountId { get; set; }

        /// <summary>
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentVersionString:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupId)]
        public int ParentVersionStringId { get; set; }

        /// <summary>
        ///(ParentVersionString)ParentVersionString:Lookup ,  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupValue)]
        public String ParentVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentLeafName:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupId)]
        public int ParentLeafNameId { get; set; }

        /// <summary>
        ///(ParentLeafName)ParentLeafName:Lookup ,  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupValue)]
        public String ParentLeafName { get; set; }

    }//Страницы

    /// <summary>
    ///  Страницы сайта 
    ///  
    ///  SitePages
    /// </summary>
    [SharepointList("Страницы сайта")]
    public partial class SitePages : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(FileLeafRef)FileLeafRef:File ,  
        /// </summary>
        [SharepointField("FileLeafRef")]
        public String FileLeafRef { get; set; }

        /// <summary>
        ///(WikiField)WikiField:Note ,  
        /// </summary>
        [SharepointField("WikiField")]
        public String WikiField { get; set; }

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
        /// </summary>
        [SharepointField("Author", MapData.LookupValue)]
        public String Author { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///lookup Id(s) for Editor:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Editor", MapData.LookupId)]
        public int EditorId { get; set; }

        /// <summary>
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_CopySource)OData__CopySource:Text ,  
        /// </summary>
        [SharepointField("OData__CopySource")]
        public String OData__CopySource { get; set; }

        /// <summary>
        ///lookup Id(s) for CheckoutUser:
        ///User 
        ///  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupId)]
        public int CheckoutUserId { get; set; }

        /// <summary>
        ///(CheckoutUser)CheckoutUser:User ,  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupValue)]
        public String CheckoutUser { get; set; }

        /// <summary>
        ///lookup Id(s) for OData__CheckinComment:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("_CheckinComment", MapData.LookupId)]
        public int _CheckinCommentId { get; set; }

        /// <summary>
        ///(_CheckinComment)OData__CheckinComment:Lookup ,  
        /// </summary>
        [SharepointField("OData__CheckinComment", MapData.LookupValue)]
        public String OData__CheckinComment { get; set; }

        /// <summary>
        ///lookup Id(s) for ItemChildCount:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ItemChildCount", MapData.LookupId)]
        public int ItemChildCountId { get; set; }

        /// <summary>
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentVersionString:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupId)]
        public int ParentVersionStringId { get; set; }

        /// <summary>
        ///(ParentVersionString)ParentVersionString:Lookup ,  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupValue)]
        public String ParentVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentLeafName:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupId)]
        public int ParentLeafNameId { get; set; }

        /// <summary>
        ///(ParentLeafName)ParentLeafName:Lookup ,  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupValue)]
        public String ParentLeafName { get; set; }

    }//Страницы сайта

    /// <summary>
    ///  Теги сообщений 
    ///  
    ///  List13List
    /// </summary>
    [SharepointList("Теги сообщений")]
    public partial class Tag : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(InputValue)InputValue:Note ,  
        /// </summary>
        [SharepointField("InputValue")]
        public String InputValue { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Теги сообщений

    /// <summary>
    ///  Текстовые страницы 
    ///  
    ///  List11List
    /// </summary>
    [SharepointList("Текстовые страницы")]
    public partial class TextPage : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for Countries:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("Countries", MapData.LookupId)]
        public List<int> CountriesId { get; set; }

        /// <summary> 
        ///lookup values for  Countries:LookupMulti ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Territory> CountriesLookUp(ISpClient client) => CountriesId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(Countries)Countries:LookupMulti ,  
        /// </summary>
        [SharepointField("Countries", MapData.LookupValue)]
        public List<String> Countries { get; set; }

        /// <summary>
        ///lookup Id(s) for Url:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Url", MapData.LookupId)]
        public int UrlId { get; set; }

        /// <summary> 
        ///lookup values for  Url:Lookup ,   LookUp list Menu
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Menu UrlLookUp(ISpClient client) => client.GetById<Menu>(UrlId);

        /// <summary>
        ///(Url)Url:Lookup ,  
        /// </summary>
        [SharepointField("Url", MapData.LookupValue)]
        public String Url { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Текстовые страницы

    /// <summary>
    ///  Тексты 
    ///  
    ///  List14List
    /// </summary>
    [SharepointList("Тексты")]
    public partial class TextPageContent : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for TextPage:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("TextPage", MapData.LookupId)]
        public int TextPageId { get; set; }

        /// <summary> 
        ///lookup values for  TextPage:Lookup ,   LookUp list TextPage
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public TextPage TextPageLookUp(ISpClient client) => client.GetById<TextPage>(TextPageId);

        /// <summary>
        ///(TextPage)TextPage:Lookup ,  
        /// </summary>
        [SharepointField("TextPage", MapData.LookupValue)]
        public String TextPage { get; set; }

        /// <summary>
        ///(Summary)Summary:Note ,  
        /// </summary>
        [SharepointField("Summary")]
        public String Summary { get; set; }

        /// <summary>
        ///lookup Id(s) for Language:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Language", MapData.LookupId)]
        public int LanguageId { get; set; }

        /// <summary> 
        ///lookup values for  Language:Lookup ,   LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContentLang LanguageLookUp(ISpClient client) => client.GetById<ContentLang>(LanguageId);

        /// <summary>
        ///(Language)Language:Lookup ,  
        /// </summary>
        [SharepointField("Language", MapData.LookupValue)]
        public String Language { get; set; }

        /// <summary>
        ///(pText)pText:Note ,  
        /// </summary>
        [SharepointField("pText")]
        public String pText { get; set; }

        /// <summary>
        ///(KeyWords)KeyWords:Text ,  
        /// </summary>
        [SharepointField("KeyWords")]
        public String KeyWords { get; set; }

        /// <summary>
        ///(SeoDescription)SeoDescription:Text ,  
        /// </summary>
        [SharepointField("SeoDescription")]
        public String SeoDescription { get; set; }

        /// <summary>
        ///(PageTitle)PageTitle:Text ,  
        /// </summary>
        [SharepointField("PageTitle")]
        public String PageTitle { get; set; }

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
        public IEnumerable<Territory> TerritoryLookUp(ISpClient client) => TerritoryId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(Territory)Territory:LookupMulti ,  
        /// </summary>
        [SharepointField("Territory", MapData.LookupValue)]
        public List<String> Territory { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Тексты

    /// <summary>
    ///  Территории 
    ///  Список территорий для публикации контента
    ///  List15List
    /// </summary>
    [SharepointList("Территории")]
    public partial class Territory : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for MontTerritory:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontTerritory", MapData.LookupId)]
        public int MontTerritoryId { get; set; }

        /// <summary> 
        ///lookup values for  MontTerritory:Lookup ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Territory MontTerritoryLookUp(ISpClient client) => client.GetById<Territory>(MontTerritoryId);

        /// <summary>
        ///(MontTerritory)MontTerritory:Lookup ,  
        /// </summary>
        [SharepointField("MontTerritory", MapData.LookupValue)]
        public String MontTerritory { get; set; }

        /// <summary>
        ///lookup Id(s) for MontTerritoryType:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontTerritoryType", MapData.LookupId)]
        public int MontTerritoryTypeId { get; set; }

        /// <summary> 
        ///lookup values for  MontTerritoryType:Lookup ,   LookUp list TerritoryType
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public TerritoryType MontTerritoryTypeLookUp(ISpClient client) => client.GetById<TerritoryType>(MontTerritoryTypeId);

        /// <summary>
        ///(MontTerritoryType)MontTerritoryType:Lookup ,  
        /// </summary>
        [SharepointField("MontTerritoryType", MapData.LookupValue)]
        public String MontTerritoryType { get; set; }

        /// <summary>
        ///(CountryCode)CountryCode:Text ,  
        /// </summary>
        [SharepointField("CountryCode")]
        public String CountryCode { get; set; }

        /// <summary>
        ///lookup Id(s) for DefaultLang:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("DefaultLang", MapData.LookupId)]
        public int DefaultLangId { get; set; }

        /// <summary> 
        ///lookup values for  DefaultLang:Lookup ,   LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContentLang DefaultLangLookUp(ISpClient client) => client.GetById<ContentLang>(DefaultLangId);

        /// <summary>
        ///(DefaultLang)DefaultLang:Lookup ,  
        /// </summary>
        [SharepointField("DefaultLang", MapData.LookupValue)]
        public String DefaultLang { get; set; }

        /// <summary>
        ///(InternalTitle)InternalTitle:Text ,  
        /// </summary>
        [SharepointField("InternalTitle")]
        public String InternalTitle { get; set; }

        /// <summary>
        ///(Langs)Langs:Text ,  
        /// </summary>
        [SharepointField("Langs")]
        public String Langs { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Территории

    /// <summary>
    ///  Территории локализация 
    ///  
    ///  List30List
    /// </summary>
    [SharepointList("Территории локализация")]
    public partial class TerritoryLocalization : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for Territory:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Territory", MapData.LookupId)]
        public int TerritoryId { get; set; }

        /// <summary> 
        ///lookup values for  Territory:Lookup ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Territory TerritoryLookUp(ISpClient client) => client.GetById<Territory>(TerritoryId);

        /// <summary>
        ///(Territory)Territory:Lookup ,  
        /// </summary>
        [SharepointField("Territory", MapData.LookupValue)]
        public String Territory { get; set; }

        /// <summary>
        ///lookup Id(s) for Language:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Language", MapData.LookupId)]
        public int LanguageId { get; set; }

        /// <summary> 
        ///lookup values for  Language:Lookup ,   LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContentLang LanguageLookUp(ISpClient client) => client.GetById<ContentLang>(LanguageId);

        /// <summary>
        ///(Language)Language:Lookup ,  
        /// </summary>
        [SharepointField("Language", MapData.LookupValue)]
        public String Language { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Территории локализация

    /// <summary>
    ///  Территории мероприятия 
    ///  
    ///  List28List
    /// </summary>
    [SharepointList("Территории мероприятия")]
    public partial class EventLocation : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

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
        public Event MontEventIdLookUp(ISpClient client) => client.GetById<Event>(MontEventIdId);

        /// <summary>
        ///(MontEventId)MontEventId:Lookup ,  
        /// </summary>
        [SharepointField("MontEventId", MapData.LookupValue)]
        public String MontEventId { get; set; }

        /// <summary>
        ///(MontPromoEventEnds)MontPromoEventEnds:DateTime ,  
        /// </summary>
        [SharepointField("MontPromoEventEnds")]
        public DateTime MontPromoEventEnds { get; set; }

        /// <summary>
        ///(MontPromoEventStarts)MontPromoEventStarts:DateTime ,  
        /// </summary>
        [SharepointField("MontPromoEventStarts")]
        public DateTime MontPromoEventStarts { get; set; }

        /// <summary>
        ///(MontEventRegStarts)MontEventRegStarts:DateTime ,  
        /// </summary>
        [SharepointField("MontEventRegStarts")]
        public DateTime MontEventRegStarts { get; set; }

        /// <summary>
        ///(MontEventRegEnds)MontEventRegEnds:DateTime ,  
        /// </summary>
        [SharepointField("MontEventRegEnds")]
        public DateTime MontEventRegEnds { get; set; }

        /// <summary>
        ///lookup Id(s) for MontTerritories:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("MontTerritories", MapData.LookupId)]
        public int MontTerritoriesId { get; set; }

        /// <summary> 
        ///lookup values for  MontTerritories:Lookup ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public Territory MontTerritoriesLookUp(ISpClient client) => client.GetById<Territory>(MontTerritoriesId);

        /// <summary>
        ///(MontTerritories)MontTerritories:Lookup ,  
        /// </summary>
        [SharepointField("MontTerritories", MapData.LookupValue)]
        public String MontTerritories { get; set; }

        /// <summary>
        ///(MontIsCanceled)MontIsCanceled:Boolean ,  
        /// </summary>
        [SharepointField("MontIsCanceled")]
        public Boolean? MontIsCanceled { get; set; }

        /// <summary>
        ///(MontPubStarts)MontPubStarts:DateTime ,  
        /// </summary>
        [SharepointField("MontPubStarts")]
        public DateTime? MontPubStarts { get; set; }

        /// <summary>
        ///(MontPubEnds)MontPubEnds:DateTime ,  
        /// </summary>
        [SharepointField("MontPubEnds")]
        public DateTime? MontPubEnds { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Территории мероприятия

    /// <summary>
    ///  Тип контента 
    ///  
    ///  List34List
    /// </summary>
    [SharepointList("Тип контента")]
    public partial class ContentType : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Controller)Controller:Text ,  
        /// </summary>
        [SharepointField("Controller")]
        public String Controller { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Тип контента

    /// <summary>
    ///  Тип контента локализация 
    ///  
    ///  List35List
    /// </summary>
    [SharepointList("Тип контента локализация")]
    public partial class ContentTypeLocalization : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for ContentType0:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ContentType0", MapData.LookupId)]
        public int ContentType0Id { get; set; }

        /// <summary> 
        ///lookup values for  ContentType0:Lookup ,   LookUp list ContentType
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContentType ContentType0LookUp(ISpClient client) => client.GetById<ContentType>(ContentType0Id);

        /// <summary>
        ///(ContentType0)ContentType0:Lookup ,  
        /// </summary>
        [SharepointField("ContentType0", MapData.LookupValue)]
        public String ContentType0 { get; set; }

        /// <summary>
        ///lookup Id(s) for Language:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Language", MapData.LookupId)]
        public int LanguageId { get; set; }

        /// <summary> 
        ///lookup values for  Language:Lookup ,   LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContentLang LanguageLookUp(ISpClient client) => client.GetById<ContentLang>(LanguageId);

        /// <summary>
        ///(Language)Language:Lookup ,  
        /// </summary>
        [SharepointField("Language", MapData.LookupValue)]
        public String Language { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Тип контента локализация

    /// <summary>
    ///  Тип мероприятия 
    ///  Список содержит возможные типы мероприятия
    ///  List18List
    /// </summary>
    [SharepointList("Тип мероприятия")]
    public partial class EventType : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Тип мероприятия

    /// <summary>
    ///  Тип мероприятия локализация 
    ///  
    ///  List33List
    /// </summary>
    [SharepointList("Тип мероприятия локализация")]
    public partial class EventTypeLocalization : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///lookup Id(s) for EventType:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("EventType", MapData.LookupId)]
        public int EventTypeId { get; set; }

        /// <summary> 
        ///lookup values for  EventType:Lookup ,   LookUp list EventType
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public EventType EventTypeLookUp(ISpClient client) => client.GetById<EventType>(EventTypeId);

        /// <summary>
        ///(EventType)EventType:Lookup ,  
        /// </summary>
        [SharepointField("EventType", MapData.LookupValue)]
        public String EventType { get; set; }

        /// <summary>
        ///lookup Id(s) for Language:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("Language", MapData.LookupId)]
        public int LanguageId { get; set; }

        /// <summary> 
        ///lookup values for  Language:Lookup ,   LookUp list ContentLang
        //fieldLookup.AllowMultipleValues:False
        /// </summary>
        public ContentLang LanguageLookUp(ISpClient client) => client.GetById<ContentLang>(LanguageId);

        /// <summary>
        ///(Language)Language:Lookup ,  
        /// </summary>
        [SharepointField("Language", MapData.LookupValue)]
        public String Language { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Тип мероприятия локализация

    /// <summary>
    ///  Тип территории 
    ///  
    ///  List23List
    /// </summary>
    [SharepointList("Тип территории")]
    public partial class TerritoryType : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Тип территории

    /// <summary>
    ///  Типы блоков страниц 
    ///  Типы блоков, которые можно вставлять на страницы
    ///  PageBlockTypeList
    /// </summary>
    [SharepointList("Типы блоков страниц")]
    public partial class PageBlockTypeList : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(IsEnabled)IsEnabled:Boolean , Блок доступен для выбора 
        /// </summary>
        [SharepointField("IsEnabled")]
        public Boolean? IsEnabled { get; set; }

        /// <summary>
        ///(IsDefault)IsDefault:Boolean , Блок по умолчанию 
        /// </summary>
        [SharepointField("IsDefault")]
        public Boolean? IsDefault { get; set; }

        /// <summary>
        ///(MontForEvents)MontForEvents:Boolean , Тип блока доступен для мероприятий 
        /// </summary>
        [SharepointField("MontForEvents")]
        public Boolean? MontForEvents { get; set; }

        /// <summary>
        ///(MontDefaultForEvents)MontDefaultForEvents:Boolean , Тип блока является типом по умолчанию для мероприятий 
        /// </summary>
        [SharepointField("MontDefaultForEvents")]
        public Boolean? MontDefaultForEvents { get; set; }

        /// <summary>
        ///(MontForPages)MontForPages:Boolean , Тип блока доступен для страниц 
        /// </summary>
        [SharepointField("MontForPages")]
        public Boolean? MontForPages { get; set; }

        /// <summary>
        ///(MontDefaultForPages)MontDefaultForPages:Boolean , Тип блока является типом по умолчанию для страниц 
        /// </summary>
        [SharepointField("MontDefaultForPages")]
        public Boolean? MontDefaultForPages { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Типы блоков страниц

    /// <summary>
    ///  Файлы сообщений 
    ///  
    ///  DocLib2
    /// </summary>
    [SharepointList("Файлы сообщений")]
    public partial class DocLib2 : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(FileLeafRef)FileLeafRef:File ,  
        /// </summary>
        [SharepointField("FileLeafRef")]
        public String FileLeafRef { get; set; }

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(MessageId)MessageId:Text ,  
        /// </summary>
        [SharepointField("MessageId")]
        public String MessageId { get; set; }

        /// <summary>
        ///(EmailSender)EmailSender:Note ,  
        /// </summary>
        [SharepointField("EmailSender")]
        public String EmailSender { get; set; }

        /// <summary>
        ///(EmailTo)EmailTo:Note ,  
        /// </summary>
        [SharepointField("EmailTo")]
        public String EmailTo { get; set; }

        /// <summary>
        ///(EmailCc)EmailCc:Note ,  
        /// </summary>
        [SharepointField("EmailCc")]
        public String EmailCc { get; set; }

        /// <summary>
        ///(EmailFrom)EmailFrom:Text ,  
        /// </summary>
        [SharepointField("EmailFrom")]
        public String EmailFrom { get; set; }

        /// <summary>
        ///(EmailSubject)EmailSubject:Text ,  
        /// </summary>
        [SharepointField("EmailSubject")]
        public String EmailSubject { get; set; }

        /// <summary>
        ///(EmailHeaders)EmailHeaders:Note ,  
        /// </summary>
        [SharepointField("EmailHeaders")]
        public String EmailHeaders { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
        /// </summary>
        [SharepointField("Author", MapData.LookupValue)]
        public String Author { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///lookup Id(s) for Editor:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Editor", MapData.LookupId)]
        public int EditorId { get; set; }

        /// <summary>
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_CopySource)OData__CopySource:Text ,  
        /// </summary>
        [SharepointField("OData__CopySource")]
        public String OData__CopySource { get; set; }

        /// <summary>
        ///lookup Id(s) for CheckoutUser:
        ///User 
        ///  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupId)]
        public int CheckoutUserId { get; set; }

        /// <summary>
        ///(CheckoutUser)CheckoutUser:User ,  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupValue)]
        public String CheckoutUser { get; set; }

        /// <summary>
        ///lookup Id(s) for OData__CheckinComment:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("_CheckinComment", MapData.LookupId)]
        public int _CheckinCommentId { get; set; }

        /// <summary>
        ///(_CheckinComment)OData__CheckinComment:Lookup ,  
        /// </summary>
        [SharepointField("OData__CheckinComment", MapData.LookupValue)]
        public String OData__CheckinComment { get; set; }

        /// <summary>
        ///lookup Id(s) for ItemChildCount:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ItemChildCount", MapData.LookupId)]
        public int ItemChildCountId { get; set; }

        /// <summary>
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentVersionString:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupId)]
        public int ParentVersionStringId { get; set; }

        /// <summary>
        ///(ParentVersionString)ParentVersionString:Lookup ,  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupValue)]
        public String ParentVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentLeafName:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupId)]
        public int ParentLeafNameId { get; set; }

        /// <summary>
        ///(ParentLeafName)ParentLeafName:Lookup ,  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupValue)]
        public String ParentLeafName { get; set; }

    }//Файлы сообщений

    /// <summary>
    ///  Шаблоны форм 
    ///  Эта библиотека содержит утвержденные администратором шаблоны форм, активированные в данном семействе веб-сайтов.
    ///  FormServerTemplates
    /// </summary>
    [SharepointList("Шаблоны форм")]
    public partial class FormServerTemplates : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(FileLeafRef)FileLeafRef:File ,  
        /// </summary>
        [SharepointField("FileLeafRef")]
        public String FileLeafRef { get; set; }

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(FormName)FormName:Text ,  
        /// </summary>
        [SharepointField("FormName")]
        public String FormName { get; set; }

        /// <summary>
        ///(FormCategory)FormCategory:Text ,  
        /// </summary>
        [SharepointField("FormCategory")]
        public String FormCategory { get; set; }

        /// <summary>
        ///(FormVersion)FormVersion:Text ,  
        /// </summary>
        [SharepointField("FormVersion")]
        public String FormVersion { get; set; }

        /// <summary>
        ///(FormId)FormId:Text ,  
        /// </summary>
        [SharepointField("FormId")]
        public String FormId { get; set; }

        /// <summary>
        ///(FormLocale)FormLocale:Text ,  
        /// </summary>
        [SharepointField("FormLocale")]
        public String FormLocale { get; set; }

        /// <summary>
        ///(FormDescription)FormDescription:Text ,  
        /// </summary>
        [SharepointField("FormDescription")]
        public String FormDescription { get; set; }

        /// <summary>
        ///(ShowInCatalog)ShowInCatalog:Boolean ,  
        /// </summary>
        [SharepointField("ShowInCatalog")]
        public Boolean? ShowInCatalog { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
        /// </summary>
        [SharepointField("Author", MapData.LookupValue)]
        public String Author { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///lookup Id(s) for Editor:
        ///User 
        ///  
        /// </summary>
        [SharepointField("Editor", MapData.LookupId)]
        public int EditorId { get; set; }

        /// <summary>
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_CopySource)OData__CopySource:Text ,  
        /// </summary>
        [SharepointField("OData__CopySource")]
        public String OData__CopySource { get; set; }

        /// <summary>
        ///lookup Id(s) for CheckoutUser:
        ///User 
        ///  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupId)]
        public int CheckoutUserId { get; set; }

        /// <summary>
        ///(CheckoutUser)CheckoutUser:User ,  
        /// </summary>
        [SharepointField("CheckoutUser", MapData.LookupValue)]
        public String CheckoutUser { get; set; }

        /// <summary>
        ///lookup Id(s) for OData__CheckinComment:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("_CheckinComment", MapData.LookupId)]
        public int _CheckinCommentId { get; set; }

        /// <summary>
        ///(_CheckinComment)OData__CheckinComment:Lookup ,  
        /// </summary>
        [SharepointField("OData__CheckinComment", MapData.LookupValue)]
        public String OData__CheckinComment { get; set; }

        /// <summary>
        ///lookup Id(s) for ItemChildCount:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ItemChildCount", MapData.LookupId)]
        public int ItemChildCountId { get; set; }

        /// <summary>
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentVersionString:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupId)]
        public int ParentVersionStringId { get; set; }

        /// <summary>
        ///(ParentVersionString)ParentVersionString:Lookup ,  
        /// </summary>
        [SharepointField("ParentVersionString", MapData.LookupValue)]
        public String ParentVersionString { get; set; }

        /// <summary>
        ///lookup Id(s) for ParentLeafName:
        ///Lookup 
        ///  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupId)]
        public int ParentLeafNameId { get; set; }

        /// <summary>
        ///(ParentLeafName)ParentLeafName:Lookup ,  
        /// </summary>
        [SharepointField("ParentLeafName", MapData.LookupValue)]
        public String ParentLeafName { get; set; }

    }//Шаблоны форм

    /// <summary>
    ///  Языки контента 
    ///  Список языков, доступных для публикации новости
    ///  List6List
    /// </summary>
    [SharepointList("Языки контента")]
    public partial class ContentLang : ISharepointItem
    {

        [SharepointField("ID")]
        public int Id { get; set; } //ID:Counter , 

        /// <summary>
        ///(Title)Title:Text ,  
        /// </summary>
        [SharepointField("Title")]
        public String Title { get; set; }

        /// <summary>
        ///(LangCode)LangCode:Text ,  
        /// </summary>
        [SharepointField("LangCode")]
        public String LangCode { get; set; }

        /// <summary>
        ///(LangPriority)LangPriority:Number ,  
        /// </summary>
        [SharepointField("LangPriority")]
        public Int32? LangPriority { get; set; }

        /// <summary>
        ///lookup Id(s) for DefaultTerritory:
        ///LookupMulti 
        ///  
        /// </summary>
        [SharepointField("DefaultTerritory", MapData.LookupId)]
        public List<int> DefaultTerritoryId { get; set; }

        /// <summary> 
        ///lookup values for  DefaultTerritory:LookupMulti ,   LookUp list Territory
        //fieldLookup.AllowMultipleValues:True
        /// </summary>
        public IEnumerable<Territory> DefaultTerritoryLookUp(ISpClient client) => DefaultTerritoryId.Select(l => client.GetById<Territory>(l));

        /// <summary>
        ///(DefaultTerritory)DefaultTerritory:LookupMulti ,  
        /// </summary>
        [SharepointField("DefaultTerritory", MapData.LookupValue)]
        public List<String> DefaultTerritory { get; set; }

        /// <summary>
        ///(Modified)Modified:DateTime ,  
        /// </summary>
        [SharepointField("Modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///(Created)Created:DateTime ,  
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
        ///(Author)Author:User ,  
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
        ///(Editor)Editor:User ,  
        /// </summary>
        [SharepointField("Editor", MapData.LookupValue)]
        public String Editor { get; set; }

        /// <summary>
        ///(_UIVersionString)OData__UIVersionString:Text ,  
        /// </summary>
        [SharepointField("OData__UIVersionString")]
        public String OData__UIVersionString { get; set; }

        /// <summary>
        ///(Attachments)Attachments:Attachments ,  
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
        ///(ItemChildCount)ItemChildCount:Lookup ,  
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
        ///(FolderChildCount)FolderChildCount:Lookup ,  
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
        ///(AppAuthor)AppAuthor:Lookup ,  
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
        ///(AppEditor)AppEditor:Lookup ,  
        /// </summary>
        [SharepointField("AppEditor", MapData.LookupValue)]
        public String AppEditor { get; set; }

    }//Языки контента

}
