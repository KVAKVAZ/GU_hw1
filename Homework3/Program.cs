using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты x1");
            var x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты x2");
            var x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты y1");
            var y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты y2");
            var y2 = Convert.ToInt32(Console.ReadLine());
            var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние = {r:F2}");
            Console.ReadLine();
        }
    }
}
