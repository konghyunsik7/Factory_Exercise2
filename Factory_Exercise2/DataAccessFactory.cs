using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Exercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccess(string databaseType)
        {
            switch (databaseType)
            {
                case "list":
                    return new ListDataAccess();
                case "sql":
                    return new SQLDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                default:
                    return new ListDataAccess();
                    
            }
        }
    }
}
