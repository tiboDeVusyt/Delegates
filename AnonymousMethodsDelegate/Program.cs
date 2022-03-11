using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodsDelegate
{
    public delegate string GreetingsDelegate(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            //GreetingsDelegate greetings = new GreetingsDelegate(Greetings);

            GreetingsDelegate greet =  (name)  =>
            {
                return $"hello {name}";
            };
            var str = greet.Invoke("Florian");
            Console.WriteLine(str);

            //string result = greetings.Invoke("florian");
            //Console.WriteLine(result);
        }
        //public static string Greetings(string name)
        //{
        //    return $"hello {name}";
        //}

    }
}
