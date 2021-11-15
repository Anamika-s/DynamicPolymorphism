using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicPolymorphism
{
    class PartimeEmployee : Employee
    {
        int duration;
        string projectName;
        public override  void GetDetails()
        {
             base.GetDetails();
            Console.WriteLine("Enter projectName");
            projectName = Console.ReadLine();
            Console.WriteLine("enter duration");
            duration = Convert.ToInt16(Console.ReadLine());

        }
        public override void DisplayDetails()
        {
             base.DisplayDetails();
            Console.WriteLine("projectName is " + projectName);
            Console.WriteLine("duration is " + duration);
             
        }
    }
}
