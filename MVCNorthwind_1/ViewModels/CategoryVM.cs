using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCNorthwind_1.ViewModels
{
    public class CategoryVM
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
       // public List<string> ProductNames { get; set; }
    }
}