using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp40
{
   public  class Program
    {
        static void Main(string[] args)
        {
           using (var context = new EmployeeContext())
            {
                List<EmployeeDetails> employees = context.EmployeeDetails.ToList();
                foreach(var employeeDetails in employees)
                {
                    Console.WriteLine(employeeDetails.Salary);
                }
            }
        }
    }
}
