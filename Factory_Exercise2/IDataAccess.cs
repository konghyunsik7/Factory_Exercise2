using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Exercise2
{
    public interface IDataAccess
    {
        public void LoadData();
        public void SaveData();
    }
}
