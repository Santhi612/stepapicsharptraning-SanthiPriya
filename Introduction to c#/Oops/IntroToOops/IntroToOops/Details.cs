using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToOops
{
    public class Details
    {
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string GetDetails()
        {
            return "FirstName is" + FirstName + "Last name is" + LastName;
        }
        //Polymorphism
        public int add()
        {
            return 2 + 3;
        }
        public int add(int a,int b)
        {
            return a + b;
        }
        public decimal add(decimal a,decimal b,decimal c)
        {
            return a + b + c;
        }
    }
    //Inheritance
    public class Student :Details
    {
        public string StudentAddress { get; set; }
    }
    public class Teacher : Details 
    {
        public string Subject { get; set; }
    }

}
