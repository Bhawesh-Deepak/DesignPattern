using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdapterDesignPattern
{
    public class EmployeeAdapter : ITarget
    {
        public void ProcessCompanySalary(string[,] employeesArray)
        {
            string Id = null;
            string Name = null;
            string department = null;
            string Salary = null;
            var employeeList = new List<Employee>();

            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                for (int j = 0; j < employeesArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Id = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Name = employeesArray[i, j];
                    }
                    else if (j == 2)
                    {
                        department = employeesArray[i, j];
                    }
                    else
                    {
                        Salary = employeesArray[i, j];
                    }
                }
                employeeList.Add(new Employee(Id, Name, department,
                    Convert.ToDecimal(Salary)));

                
            }
            new ThirdPartySalaryProcess().ProcessEmployeeSalary(employeeList);
        }
    }
}
