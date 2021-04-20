using System;
using System.Collections.Generic;
//public delegate void HelloFunctionDelegate(string msg);

namespace IntroToDelegates
{
    class Program
    {
        public static void Main(string[] args)
        {
            //HelloFunctionDelegate msg = new HelloFunctionDelegate(Hello);
            //msg("Hello from delegate");
            List<Employee> emplist = new List<Employee>();

            emplist.Add(new Employee() { Id = 101, Name = "santhi", Salary = 5000, Experience = 5 });
            emplist.Add(new Employee() { Id = 101, Name = "priya", Salary = 4000, Experience = 6 });
            emplist.Add(new Employee() { Id = 101, Name = "siva", Salary = 6000, Experience = 3});
            emplist.Add(new Employee() { Id = 101, Name = "kumar", Salary = 3000, Experience = 4 });

            //IsPromotable isPromotable = new IsPromotable(Promote);

            Employee.PromoteEmployee(emplist, emp=>emp.Experience>=5);     //using lamda expressions
        }

           /* public static bool Promote(Employee emp)
            {
                if (emp.Experience >= 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                   
            }*/

       /* public static void Hello(string strMsg)
        {
            Console.WriteLine(strMsg);
        }*/

    }
    delegate bool IsPromotable(Employee empl); 
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public static void PromoteEmployee(List<Employee> empList, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in empList)
            {
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + "Promoted");
                }
            }
        }
    }
}
