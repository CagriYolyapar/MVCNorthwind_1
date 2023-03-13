using MVCNorthwind_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCNorthwind_1.DesignPatterns.SingletonPattern
{
    public class DBTool
    {
        DBTool() { }

        static NorthwindEntities _dbInstance;

        public static NorthwindEntities DbInstance
        {
            get
            {
                if(_dbInstance == null ) _dbInstance = new NorthwindEntities();
                return _dbInstance;
            }
        }
    }
}