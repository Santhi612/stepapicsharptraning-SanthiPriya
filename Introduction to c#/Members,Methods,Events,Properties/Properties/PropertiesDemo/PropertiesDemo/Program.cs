using System;

namespace PropertiesDemo
{
    public class Student
    {
        private int _ID;
        private string _Name;
        private int _PassMark=35;
        public string Email{ get; set; }
        public string City{get;set;}
        
        public int PassMark
        {
            get
            {
                return this._PassMark; 
            }
           
        }
        public String Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._Name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
            }
            
        }
        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student Id Cannot be negative");
                }
                this._ID = value;
            } 
            get
            {
                return this._ID;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Student C1 = new Student();//All rules are Violated
            C1.ID = -101;
            C1.Name = null;
            C1.PassMark = 0;
            Console.WriteLine("Id={0} && Name={1} && PassMark={2}",C1.ID, C1.Name, C1.PassMark);*/
            Student C1 = new Student();
            C1.Id = 101;
            C1.Name="santhi";
            C1.City = "Guntur";
            C1.Email = "abcd@gmail.com";
            Console.WriteLine("Student Id={0} ", C1.Id);
            Console.WriteLine("Student Name={0} ", C1.Name);
            Console.WriteLine("Student PassMark={0} ", C1.PassMark);
            Console.WriteLine("Student City={0} ", C1.City);
            Console.WriteLine("Student Email={0} ", C1.Email);
        }
    }
}
