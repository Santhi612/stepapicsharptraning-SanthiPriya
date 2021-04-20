using System;

namespace FlowControlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int value;
            string s = Console.ReadLine();
            if(int.TryParse(s,out value))
            {
                switch(value)
                {
                    case 1:
                        Console.WriteLine("You entered 1");
                        break;
                    case 2:
                        Console.WriteLine("You entered 2");
                        break;
                    default:
                        Console.WriteLine("you entered something else");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Got an String!");
            }*/
            for(int j=1;j<=20;j++)
            {
                if (j == 5)
                    continue;
                Console.WriteLine(j);
            }
            
            int i = 1;
            do
            {
               if (i == 5)
                   break;
                Console.WriteLine(i);
                i++;
            } while (i <= 20);
            Console.ReadLine();
        }
    }
}
