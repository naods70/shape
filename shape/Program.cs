using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;




namespace shape
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius: ");
            double Radious = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * Radious * Radious;
            Console.WriteLine("Area of circle: " + Area);
            Console.ReadKey();
        }

        public static void Main()
        {

            double r, per_cir;
            double PI = 3.14;
            Console.WriteLine("Input the radius of the circle : ");
            r = Convert.ToDouble(Console.ReadLine());
            per_cir = 2 * PI * r;
            Console.WriteLine("Perimeter of Circle : {0}", per_cir);
            Console.Read();
        }
    }
}