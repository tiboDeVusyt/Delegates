using System;

namespace SimpleDelegate
{
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);
    internal class Program
    {
        //1.simple
        //2.Miltiple
        //3.Genaric Delegate
        static void Main(string[] args)
        {
            Program P = new Program();
            AddDelegate ad = new AddDelegate(P.AddNumbers);
            ad(2, 3);
            SayDelegate sd = new SayDelegate(SayHello);
            Console.WriteLine(sd("kenan"));

            Console.ReadLine();
        }
        public void AddNumbers( int a , int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)
        {
            return $"hello {name}";
        }
    }
}
