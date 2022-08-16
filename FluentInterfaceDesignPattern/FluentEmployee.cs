using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterfaceDesignPattern
{
    public class FluentEmployee
    {
        public Employee emp = new Employee();

        public FluentEmployee EmployeeName(string empName)
        {
            emp.EmployeeName = empName;
            return this;
        }

        public FluentEmployee WorkingOnDepartment(string deptName)
        {
            emp.DepartmentName = deptName;
            return this;
        }

        public FluentEmployee GettingSalary(decimal salary)
        {
            emp.Salary   = salary;
            return this;
        }
    }
}
