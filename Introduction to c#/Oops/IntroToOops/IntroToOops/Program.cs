using System;

namespace IntroToOops
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abs = new Abstraction();
            abs.OrderId = "101";
            abs.OrderValue = "1000";
            abs.OrderCountry = "santhi";

            abs.CreateOrder();
            Student student = new Student();
            student.FirstName = "Santhi";
            student.LastName = "Priya";
            student.StudentAddress = "TestAddress";
            student.GetDetails();
        }
    }
}
