using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class ThirdPartySalaryProcess
    {
        public void ProcessEmployeeSalary(IEnumerable<Employee> empList)
        {
            foreach (var item in empList)
            {
                Console.WriteLine($"Salary $ {item.Salary}" +
                    $" has been credit to ${item.EmpName} account");

            }
        }
    }
}
