namespace AdapterDesignPattern
{
    public class Employee
    {
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Employee(string empCode, string empName, string department, decimal salary)
        {
            EmpCode = empCode;
            EmpName = empName;
            Department = department;
            Salary = salary;
        }
    }
}