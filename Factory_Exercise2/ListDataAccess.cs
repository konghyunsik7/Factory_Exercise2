using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Exercise2
{
    public class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from List Data Access");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a List Data Access");
        }
    }
}
