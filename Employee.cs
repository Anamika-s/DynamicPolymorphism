using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicPolymorphism
{
    class Employee
    {
        int id;
        string name;
        string department;
        public  virtual void GetDetails()
        {
            Console.WriteLine("Enter ID");
            id = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("enter Department");
            department = Console.ReadLine();

        }
        
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Id is " + id);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Department is " + name);
        }

    }
}
