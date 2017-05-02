using System.Collections.Generic;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shmapper;

namespace SpTest
{
    [TestClass]
    public class MapTest
    {private static ISpClient  spclient;
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            // _sharepointClient = new SharepointClient("http://sp-dev2016-obl.mont.ru/sites/b2b", new NetworkCredential("SP_Portal", "Mont2010"));
            spclient = new SpClient(new SharepointClient("http://sp-dev2016-obl.mont.ru/sites/b2b", new NetworkCredential("SP_Portal", "Mont2010")));
        }


        [TestMethod]
        public void TestMethod1()
        {
            var eventBlocksList = spclient.GetById<EventBlocksList>(18);
            //List<SpVendorBlock> spVendorBlocks = _sharepointClient.GetAll<SpVendorBlock>();
        }        [TestMethod]
        public void GetAll_EventBlocksList()
        {
            var eventBlocksList = spclient.GetAll<EventBlocksList>();
            //List<SpVendorBlock> spVendorBlocks = _sharepointClient.GetAll<SpVendorBlock>();
        }
    }
}