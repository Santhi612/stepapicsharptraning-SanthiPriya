using System;

namespace Oops_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abs = new Abstraction();
            abs.OrderNo = "101";
            abs.OrderValue = "1000";
            abs.OrderCountry = "India";
            abs.CreateOrder();

            Student student = new Student();
            student.FirstName = "santhi";
            student.LastName = "priya";
            student.StudentAddress = "Testadress";
            student.GetDetails();



        }
    }
}
