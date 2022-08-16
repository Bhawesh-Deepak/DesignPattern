namespace ProtoTypeDesignPattern
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public decimal Salary { get; set; }
        public string DepartmentName { get; set; }
        public Address Address { get; set; }

        public Employee GetCloneObject()
        {
            return (Employee)this.MemberwiseClone();
        }
    }

    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string StateName { get; set; }
        public string ZipCode { get; set; }
    }
}