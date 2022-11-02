using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class EmployeeInformation
    {
        public double salary { get;set;}
       // public EmployeeInformation()
        //{
            
        //}

        public void EmployeeMethod()
        {
            string ename;
            int age;
           // double salary;
            int id;
            Console.WriteLine("Enter employ name:");
            ename=Console.ReadLine();
            Console.WriteLine("Enter employee salary:");
            salary=Convert.ToDouble(Console.ReadLine());    
            Console.WriteLine("Enter employee age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee Id:");
            id = Convert.ToInt32(Console.ReadLine());

        }
    }
}
