using System;
public delegate void SampleDelegate(out int Integer);
namespace MultiCastDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*SampleDelegate del1, del2, del3, del4;
            del1 = new SampleDelegate(SampleMethodOne);
            del2 = new SampleDelegate(SampleMethodTwo);
            del3 = new SampleDelegate(SampleMethodThree);
            del4 = del1 + del2 + del3-del2;
            del4();         //multicast delegate*/
            SampleDelegate del1 = new SampleDelegate(SampleMethodOne);
            del1 += SampleMethodTwo;
            int DelegateReturnedOutputParameterValue = -1;
            del1(out DelegateReturnedOutputParameterValue);
            Console.WriteLine("DelegateReturnedOutputParameterValue={0}", DelegateReturnedOutputParameterValue);
        }
        /*public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");
        }
        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }*/
        public static void SampleMethodOne(out int Number)
        {
            Number = 1;
        }
        public static void SampleMethodTwo(out int Number)
        {
            Number=2;
        }

    }
}
