using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWeb_TareaMartin.Models
{
    public class User
    {
        public int id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string email { get; set; }

        public string password { get; set; }

    }
}
