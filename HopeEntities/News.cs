using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeEntities
{
    public class News
    {
        public int NewsId { get; set; }
        public string NewsName { get; set; }
        public string NewsDescription { get; set; }

        //NewsDetails
        public string NewsTitle { get; set; }
        public string NewsSubTitle { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public Category Category { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }


    }
}
