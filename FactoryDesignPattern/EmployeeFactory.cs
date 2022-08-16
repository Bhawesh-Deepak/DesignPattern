using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public abstract class EmployeeFactory
    {
        public abstract Employee CreateEmployee();
    }
    public class TempEmployeeFactory : EmployeeFactory
    {
        public override Employee CreateEmployee()
        {
           return new TempEmployee();
        }
    }

    public class PermanentEmployeeFactory : EmployeeFactory
    {
        public override Employee CreateEmployee()
        {
            return new PermanentEmployee();
        }
    }

    public class ContractEmployeeFactory : EmployeeFactory
    {
        public override Employee CreateEmployee()
        {
            return new ContractEmployee();
        }
    }
}
