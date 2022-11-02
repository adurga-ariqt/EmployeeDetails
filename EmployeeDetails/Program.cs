// See https://aka.ms/new-console-template for more information
using EmployeeDetails;

Console.WriteLine("Hello, World!");

EmployeeInformation obj = new EmployeeInformation();
obj.EmployeeMethod();
EmployeeSalaryDetails obj2=new EmployeeSalaryDetails();
obj2.EmployeeSalaryMethod();
Console.WriteLine("HRA is :" + obj2.HRA);
Console.WriteLine("DAis :" + obj2.DA);
Console.WriteLine("TA is :" + obj2.TA);
Console.WriteLine("Tax is :" + obj2.Tax);
Console.WriteLine("Netsalary is:" + obj2.Netsalary);


