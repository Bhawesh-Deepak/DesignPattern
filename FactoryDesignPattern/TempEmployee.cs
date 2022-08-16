using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class TempEmployee : Employee
    {
        public decimal GetEmployeeAmount()
        {
            return 3000;
        }

        public int GetEmployeeHour()
        {
            return 5;
        }

        public string GetEmployeeType()
        {
            return "Temprory Employee";
        }
    }
}
