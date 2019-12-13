using HopeDAL.Database;
using HopeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeDAL.Repository
{
    public class NewsRepository
    {
        public List<News> GetAllNews()
        {
            List<News> news;
            using (ProjectContext databaseContext = new ProjectContext())
            {
                news = databaseContext.News.ToList();
            }

            return news;
        }
    }
}
