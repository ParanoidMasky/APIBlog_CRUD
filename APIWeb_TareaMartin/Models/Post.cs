using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWeb_TareaMartin.Models
{
    public class Post
    {
        public int id { get; set; }

        public string title { get; set; }

        public string content { get; set; }

        public string publishedAt { get; set; }  //alternative datetime

        public int userID { get; set; }
    }
}
