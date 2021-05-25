using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя ");
            var name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите вашу фамилию ");
            var surName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите ваш возраст ");
            var age = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите ваш рост ");
            var height = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите ваш вес ");
            var weight = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Имя: " + name + " Фамилия: " + surName + " Возраст: " + age + " Рост: " + height + " Вес: " + weight);
            Console.WriteLine("Имя: {0} {1} Возраст:{2} Рост:{3}  Вес:{4}", name, surName, age, height, weight);
            Console.WriteLine($"Имя: {name} {surName} Возраст:{age} Рост:{height}  Вес:{weight}");
            Console.ReadLine();

        }
    }
}
