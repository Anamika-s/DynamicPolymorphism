using System;

namespace DynamicPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.GetDetails();
            PartimeEmployee partime = new PartimeEmployee();
            partime.GetDetails();
            employee = partime;
            employee.GetDetails(); // Compile time/ Static / Early
            employee.DisplayDetails();
        }
    }
}
