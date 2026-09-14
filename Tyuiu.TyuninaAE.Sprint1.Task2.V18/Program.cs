using System;

using Tyuiu.TyuninaAE.Sprint1.Task2.V18.Lib;

namespace Tyuiu.TyuninaAE.Sprint1.Task2.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Тюнина А. Е. | ИБКСб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Тюнина Александра Евгеньевна | ИБКСб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Известны длины сторон параллелепипеда. Вычислить площадь боковой        *");
            Console.WriteLine("* поверхности параллелепипеда.                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите длину параллелепипеда: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину параллелепипеда: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту параллелепипеда: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Площадь боковой поверхности: " + ds.CalculateSideSquareParallelepiped(length, width, height));

            Console.ReadKey();
        }
    }
}
