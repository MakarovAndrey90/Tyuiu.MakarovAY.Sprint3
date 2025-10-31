using System.Runtime.Serialization.Formatters;
using Tyuiu.MakarovAY.Sprint3.Task7.V18.Lib;
namespace Tyuiu.MakarovAY.Sprint3.Task7.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Макаров А. Я. | РППБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Макаров А. Я. | РППБ-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции F(x)       *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5; 5]           *");
            Console.WriteLine("*            F(x) =    2x - 3                                             *");
            Console.WriteLine("*                    ----------  + 5                                      *");
            Console.WriteLine("*                    cos(x) + x                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5; int stopValue = 5;
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] ValueArray;
            ValueArray = new double[len];
            ValueArray = ds.GetMassFunction(startValue, stopValue);



            Console.WriteLine("* Старт Шага = " + startValue);
            Console.WriteLine("* Конец Шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   F(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len - 1; i++) 
            {
                Console.WriteLine("| {0,4:d}     |  {1, 5:f2}   |", startValue, ValueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();

        }
    }
}