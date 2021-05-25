using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш рост в сантиметрах");
            var h = Convert.ToInt32(Console.ReadLine());       
            double heightMetr = Convert.ToDouble(h);
            heightMetr = heightMetr / 100;
            Console.WriteLine("Введите ваш вес ");
            var m = Convert.ToInt32(Console.ReadLine());
            double weight = Convert.ToDouble(m);
            var imt = weight / (heightMetr * heightMetr);
            Console.WriteLine($"Инедекс массы тела = {imt:F2} кг/м^2");
        }
    }
}
