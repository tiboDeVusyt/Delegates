using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDelegate
{
    public delegate void RecDelegate(double x, double y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            RecDelegate recDelegate = new RecDelegate(p.GetArea);
            recDelegate += p.GetPerimeter;
            recDelegate.Invoke(12.55, 5.60);
            //recDelegate(12.55, 5.60);

        }
        public void GetArea(double width,double height)
        {
            Console.WriteLine( width * height);
        }
        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine(2*(width+height));
        }
    }
}
