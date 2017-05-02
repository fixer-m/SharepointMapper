using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using Shmapper;



namespace SpTest
{

    public interface ISpClient
    {
        List<T> Query<T>(Expression<Func<T, bool>> filter) where T : ISharepointItem, new();
        List<T> Query<T>(string camlQueryString) where T : ISharepointItem, new();
        List<T> GetAll<T>() where T : ISharepointItem, new();
        T GetById<T>(int id) where T : ISharepointItem, new();
        void Update<T>(T entity) where T : ISharepointItem, new();
        void Update<T>(IEnumerable<T> entities) where T : ISharepointItem, new();
        void Delete<T>(T entity) where T : ISharepointItem, new();
        void Delete<T>(IEnumerable<T> entities) where T : ISharepointItem, new();

        void Insert<T>(T entitiy) where T : ISharepointItem, new();
        void Insert<T>(IEnumerable<T> entities) where T : ISharepointItem, new();
    }
    /// <summary>
    ///  wrapper SharepointClient for testability
    /// </summary>
    /// <typeparam name="T"> storage poco class for Sharepoint entities </typeparam>
    public class SpClient : ISpClient
    {
        private SharepointClient spClient;// = new SharepointClient("http://sp-dev2016-obl.mont.ru/sites/b2b", new NetworkCredential("SP_Portal", "Mont2010"));

        public SpClient(SharepointClient sc)
        {


            spClient = sc;
        }

        public List<T> Query<T>(Expression<Func<T, bool>> filter) where T : ISharepointItem, new()
        {
            return spClient.Query(filter);
        }

        public List<T> Query<T>(string camlQueryString) where T : ISharepointItem, new()
        {
            return spClient.Query<T>(camlQueryString);
        }

        public List<T> GetAll<T>() where T : ISharepointItem, new()
        {
            return spClient.GetAll<T>();
        }

        public T GetById<T>(int id) where T : ISharepointItem, new()
        {
            return spClient.GetById<T>(id);
        }

        public void Update<T>(T entity) where T : ISharepointItem, new()
        {
            spClient.Update(entity);
        }

        public void Update<T>(IEnumerable<T> entities) where T : ISharepointItem, new()
        {
            spClient.Update(entities);
        }

        public void Delete<T>(T entity) where T : ISharepointItem, new()
        {
            spClient.Delete(entity);
        }

        public void Delete<T>(IEnumerable<T> entities) where T : ISharepointItem, new()
        {
            spClient.Delete(entities);
        }

        public void Insert<T>(T entitiy) where T : ISharepointItem, new()
        {
            spClient.Insert<T>(entitiy);
        }

        public void Insert<T>(IEnumerable<T> entities) where T : ISharepointItem, new()
        {
            spClient.Insert(entities);
        }
    }





}