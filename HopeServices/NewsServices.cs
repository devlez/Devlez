using HopeDAL.Database;
using HopeDAL.Repository;
using HopeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeServices
{
    public class NewsServices
    {
        private NewsRepository _newsRepository;

        public NewsServices()
        {
            _newsRepository = new NewsRepository();
        }

        public List<News> GetNews()
        {
            var newsList = _newsRepository.GetAllNews();
            return newsList;
        }

        //TODO : Burası hatalı kullanım olacak çünkü EF Bağımlılığı var | SRP, OCP ye zıt !

        //public List<News> GetAllNews()
        //{
        //    List<News> list = new List<News>();
        //    using (ProjectContext database = new ProjectContext())
        //    {
        //        list = database.News.ToList();
        //    }
            
        //}
    }
}
