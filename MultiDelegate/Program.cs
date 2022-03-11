using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDelegate
{
    public delegate double RecDelegate(double x, double y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            RecDelegate recDelegate = new RecDelegate(p.GetArea);
            recDelegate += p.GetPerimeter;
            recDelegate += p.GetPerimeter;
            recDelegate -= p.GetPerimeter;
            recDelegate -= p.GetPerimeter;
            recDelegate += p.GetArea;

            recDelegate.Invoke(12.55, 5.60);
            Console.WriteLine();
            //recDelegate(12.55, 5.60);
            Console.ReadLine();
        }
        public double GetArea(double width,double height)
        {
            return (width * height);
        }
        public double GetPerimeter(double width, double height)
        {
            return 2 * (width + height);
        }
    }
}
