using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blogTraceWPFWithStyle
{
    public class News
    {
            public string Headline { get; set; }
            public string Content { get; set; }
            public string Data { get; set; }
            public string NameUser { get; set; }
                
            public News()
            {

            }

            public News(string headline, string content, string data, string nameUser)
            {
                Headline = headline;
                Content = content;
                Data = data;
                NameUser = nameUser;
            }
    }

     public class CurrentEvents
     {
        public List<News> news;

        public CurrentEvents()
        {
            news = new List<News> { };
        }

     }
}
