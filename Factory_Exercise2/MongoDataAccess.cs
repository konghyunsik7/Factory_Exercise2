﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Exercise2
{


    public class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from MongoDataAcess");
        }

        

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a MongoDataAcess");
        }
    }
}
