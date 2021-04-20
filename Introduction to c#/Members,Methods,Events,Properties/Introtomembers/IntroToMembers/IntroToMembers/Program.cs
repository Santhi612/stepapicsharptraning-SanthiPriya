using System;

namespace IntroToMembers
{
    class Program
    {
        static float _PI;   //Static member
        int _Radius;        //Instance member
        static Program()
        {
            Console.WriteLine("Static Constructor called");
            Program._PI = 3.14F;
        }
        public Program(int Radius)
        {
            Console.WriteLine("Instance Constructor called");
            this._Radius = Radius;
        }
        public float CalculateArea()
        {
            return Program._PI * this._Radius * this._Radius;

        }
      

        static void Main(string[] args)
        {
            Program p1 = new Program(5);
            float Area1 = p1.CalculateArea();
            Console.WriteLine("Area of the circle={0}", Area1);

            Program p2 = new Program(6);
            float Area2 = p2.CalculateArea();
            Console.WriteLine("Area of the Circle={0}", Area2);
        }
    }
}
