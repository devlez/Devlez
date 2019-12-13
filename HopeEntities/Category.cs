using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeEntities
{
    public class Category
    {
        public Category()
        {
            NewsList = new List<News>();  //Her çağırıldığında NEW lensin diye yapıyoruz !
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public IEnumerable<News> NewsList { get; set; }


    }
}
