using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[4];
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine("Введите координаты {0}-й точки", i + 1);
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                double z = Convert.ToDouble(Console.ReadLine());
                double e = Convert.ToDouble(Console.ReadLine());
                points[i] = new Point(x, y, z, e);
                    Console.ReadKey();
            }
        }
    }
}