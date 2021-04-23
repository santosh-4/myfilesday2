using System;
 
class Employee
{
    public  int EmployeeID { get; set;}
    public string Name { get; set; }
}
class class8
{
  static void Main ()
  {
     Employee emp = new Employee();
     emp.EmployeeID = 101;
     emp.Name = "Santosh";
     Employee emp2 = new Employee();
     emp2.EmployeeID = 102;
     emp2.Name = "Sudheer";
     Console.WriteLine(emp.Equals(emp2));
  }
}