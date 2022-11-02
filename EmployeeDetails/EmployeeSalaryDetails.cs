using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class EmployeeSalaryDetails
    {
        public double HRA { get; set; }
        public double TA{ get; set; }
        public double Tax { get; set; }
        public double DA { get; set; }
        public double Netsalary { get; set; }
       // public double salary { get; set; }

        public void EmployeeSalaryMethod()
        {

            //Console.WriteLine("Enter salary:");
            //salary=Convert.ToDouble(Console.ReadLine());
            EmployeeInformation obj1 = new EmployeeInformation();
           Console.WriteLine("salary is:" +obj1.salary);
            if( obj1.salary<10000)
            {
                HRA =obj1.salary * 0.2;
                TA = obj1.salary * 0.1;
                Tax = obj1.salary * 0.1;
                DA = obj1.salary * 0.15;

            }
            else
            {
                HRA = obj1.salary * 0.3;
                TA = obj1.salary * 0.15;
                Tax = obj1.salary * 0.2;
                DA = obj1.salary * 0.2;

            }
            Netsalary = obj1.salary + HRA + TA + DA - Tax;

        }
 
    }
}
