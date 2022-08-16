using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class PermanentEmployee : Employee
    {
        public decimal GetEmployeeAmount()
        {
            return 10000;
        }

        public int GetEmployeeHour()
        {
            return 48;
        }

        public string GetEmployeeType()
        {
            return "Permanent Employee";
        }
    }
}
