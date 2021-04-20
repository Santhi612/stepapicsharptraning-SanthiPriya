using System;
using System.Collections.Generic;
using System.Text;

namespace Introtomethods
{
    class MethodParams
    {
        //public static void SampleMethod(int i)  pass by value 
        public static void SampleMethod( ref int i) //Pass by reference
        {
            i = 101;
        }
        public static void  Calculate(int FN,int SN,out int sum,out int product)   //Out parameters
        {
            sum= FN + SN;
            product = FN * SN;
        }
        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("There are {0} elemets", Numbers.Length);
            foreach(int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
    
}
