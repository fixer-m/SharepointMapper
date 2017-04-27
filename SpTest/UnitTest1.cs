using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shmapper;

namespace SpTest
{
    [TestClass]
    public class DevSpConTest
    {
        private static  SharepointClient _sharepointClient;
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            _sharepointClient = new SharepointClient("http://sp-dev2016-obl.mont.ru/sites/b2b", new NetworkCredential("SP_Portal", "Mont2010"));
          //  _sharepointClient = new SharepointClient("http://sp-wfe-test01/sites/b2b", new NetworkCredential("SP_Portal", "Mont2010"));
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
        public void TestMethod3()
        {
          //  List<EventContent> eventContents = _sharepointClient.GetAll<EventContent>();
            var ecc= _sharepointClient.Query<EventContent>(ec => ec.MontBlocksId==new List<int>(1)).FirstOrDefault();//x=> (x["MontBlocks"]== (DataTypes.LookupMultiId)"1")
         //   _sharepointClient.Query<EventBlocksList>("");

        }
        [TestMethod]
        public void TestMethod4()
        {
            var ecc = _sharepointClient.Test<EventContent>().ToList();

        }

        [TestMethod]
        public void MapEventBlock()
        {
           
            List<EventBlocksList> spVendorBlocks = _sharepointClient.GetAll<EventBlocksList>();

        }


        [TestMethod]
        public void MapEvents()
        {

            List<EventContent> spVendorBlocks = _sharepointClient.GetAll<EventContent>();

        }
        [TestMethod]
        public void GeneratePocoClasses()
        {
            Dictionary<string, string> recodeClassNames = new Dictionary<string, string>()
            {
                { "Аудитории","Audience"},
                { "Баннеры","Banner"},
                { "Территории","Territory"},
                { "Тип территории","TerritoryType"},
                { "Территории локализация","TerritoryLocalization"},
                { "Список мероприятий","Event"},
                { "Языки контента","ContentLang"},
                { "Библиотека стилей","StyleLibrary"},
                { "Вендоры","Vendor"},
                { "Вендоры локализация","VendorLocalization"},
                { "Внешние ссылки","ExternalReference"},
                { "Внешние ссылки локализация","ExternalReferenceLocalization"},
                { "Группы доступа","AudienceRole"},
                { "Документы","SharedDocuments"},
                { "Задачи рабочего процесса","WorkProcessTask"},
                { "Изображения","Image"},
                { "Категории","Category"},
                { "Категории локализация","CategoryLocalization"},
                { "Менеджеры","Manager"},
                { "Менеджеры локализация","ManagerLocalization"},
                { "Меню","Menu"},
                { "Меню локализация","MenuLocalization"},
                { "Направления Бизнеса","BusnessType"},
                { "Направления Бизнеса локализованные","BusnessTypeLocalization"},
                { "Настройки","Setting"},
                { "Настройки уведомлений","NotificationSetting"},
                { "Ресурсы","Resource"},
                { "Решения","Decisions"},
                { "Решения локализация","DecisionsLocalization"},
                { "Роли","Role"},
                { "Содержание акций","PromotionContent"},
                { "Содержание новостей","NewsContent"},
                { "Сообщения - Связаться с нами","LinkWithUs"},
                { "Список акций","Promotion"},
                { "Список новостей","News"},
                { "Список сообщений","Notification"},
                { "Статус мероприятия","EventStatus"},
                { "Территории мероприятия","EventLocation"},
                { "Статус мероприятия локализация","EventStatusLocalization"},
                { "Содержание мероприятий","EventContent"},
                { "Тип мероприятия","EventType"},
                { "Тип мероприятия локализация","EventTypeLocalization"},//Localization
                { "Статусы публикации","PublishStatus"},
                { "Теги сообщений","Tag"},
                { "Текстовые страницы","TextPage"},
                { "Тексты","TextPageContent"},
                { "Тип контента","ContentType"},
                { "Тип контента локализация","ContentTypeLocalization"},

            };


            string generatePocoClasses = _sharepointClient.GeneratePocoClasses(recodeClassNames);
            Console.Write(generatePocoClasses);
        }

        //Содержание мероприятий

        //Блок страницы мероприятий
    }


}
