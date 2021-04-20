using System;

namespace Introtomethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program(); //for instance methods
                                       //p.EvenNumbers();
                                       // Program.EvenNumbers(20);  //Static methods
                                       // int res = p.AddNumber(10, 20);
                                       // Console.WriteLine("sum ={0}", res);
            int j = 10;
            // MethodParams.SampleMethod(j);//Pass by value
            MethodParams.SampleMethod(ref j);
            Console.WriteLine(j);
            int sum = 0;
            int product = 0;
            MethodParams.Calculate(10, 20, out sum, out product);
            Console.WriteLine("Sum={0} & Product={1}", sum, product);
            int[] num = new int[3];
            num[0] = 101;
            num[1] = 102;
            num[2] = 103;
            //MethodParams.ParamsMethod();
            //MethodParams.ParamsMethod(num);
            MethodParams.ParamsMethod(1,2,3,4,5);

        }
        public int AddNumber(int FN, int LN)
        {
            return FN + LN;
        }
        public static void EvenNumbers(int target)
        {
            int start = 0;
            while (start <= target)
            {
                if (start % 2 == 0)
                    Console.WriteLine(start);

                start += 1;
            }
        }
    }
}

