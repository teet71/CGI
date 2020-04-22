using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CGI_filmid.Models
{
    public class Category
    {
        public int id;
        public string name;

        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }


}