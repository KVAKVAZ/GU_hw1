using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
//    а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
//  Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
//б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

{

    class Program

    {
       // static class calculcate(x1, x2, y1, y2){
         //   var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))

            //}
        static void Main(string x1,string x2,string y1, string y2)
        {
            Console.WriteLine("Введите координаты x1");
            x1 = (Console.ReadLine());
            var x3 = Convert.ToInt32(x1);
            Console.WriteLine("Введите координаты x2");
            x2 = (Console.ReadLine());
            var x4 = Convert.ToInt32(x2);
            Console.WriteLine("Введите координаты y1");
            y1 = (Console.ReadLine());
            var y3 = Convert.ToInt32(y1);
            Console.WriteLine("Введите координаты y2");
            y2 = (Console.ReadLine());
            var y4 = Convert.ToInt32(y2);
            var r = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine($"Расстояние = {r:F2}");
            Console.ReadLine();
        }
        //
    }
}
