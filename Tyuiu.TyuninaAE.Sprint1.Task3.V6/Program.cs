using System;

using Tyuiu.TyuninaAE.Sprint1.Task3.V6.Lib;

namespace Tyuiu.TyuninaAE.Sprint1.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Тюнина А. Е. | ИБКСб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Тюнина Александра Евгеньевна | ИБКСб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить стоимость поездки на автомобиле на дачу (туда и обратно).     *");
            Console.WriteLine("* Исходные данные: расстояние до дачи (км), расход бензина на 100 км,     *");
            Console.WriteLine("* цена одного литра бензина. Ответ округлить до 3 знаков после запятой.   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Расстояние до дачи (км) -> ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Расход бензина (литров на 100 км пробега) -> ");
            double gasFlow = Convert.ToDouble(Console.ReadLine());
            Console.Write("Цена литра бензина (руб.) -> ");
            double gasPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Поездка на дачу и обратно обойдется в " + ds.TravelCost(distance, gasFlow, gasPrice) + " руб.");

            Console.ReadKey();
        }
    }
}
