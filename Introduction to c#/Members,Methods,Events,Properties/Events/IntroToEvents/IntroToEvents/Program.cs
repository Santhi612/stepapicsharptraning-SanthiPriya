using System;

namespace IntroToEvents
{
    public delegate void Transformer(int x);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a Number");
            int i = int.Parse(Console.ReadLine());
            Transformer t;
            t = Square;
            t += Cuber;
            t.Invoke(i);
            NotificationOfMethods obj = new NotificationOfMethods();
            obj.TransformerEvent += User1.Xhandler;
            obj.TransformerEvent -= User2.Yhandler;
            obj.NotifyOnCell(i);
            Console.ReadLine();
        }
        static void Square(int x)
        {
            Console.WriteLine(x * x);
        }
        static void Cuber(int x)
        {
            Console.WriteLine(x * x * x);
        }
    }
    class NotificationOfMethods
    {
        public event Transformer TransformerEvent;
        public void NotifyOnCell(int x)
        {
            if(TransformerEvent !=null)
            {
                TransformerEvent(x);
            }
        }
    }
    class User1
    {
        public static void Xhandler(int x)
        {
            Console.WriteLine("Event received by user1 object");
        }
    }
    class User2
    {
        public static void Yhandler(int x)
        {
            Console.WriteLine("Event received by user2 object");
        }
    }


}
