using System;
using Tyuiu.TyuninaAE.Sprint1.Task7.V2.Lib;

namespace Tyuiu.TyuninaAE.Sprint1.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Тюнина А. Е. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Тюнина Александра Евгеньевна | ИБКСб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
            Console.WriteLine("* z = (sin(x) + cos(y)) / (cos(x) - sin(y)) * tg(x * y)                   *");
            Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.Write("* Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("* Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("* z = " + ds.Calculate(x, y));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
