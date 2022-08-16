using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class ContractEmployee : Employee
    {
        public decimal GetEmployeeAmount()
        {
            return 7000;
        }

        public int GetEmployeeHour()
        {
            return 10;
        }

        public string GetEmployeeType()
        {
            return "Contract Employee";
        }
    }
}
