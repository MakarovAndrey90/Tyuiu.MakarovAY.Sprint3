using Tyuiu.MakarovAY.Sprint3.Task5.V20.Lib;
namespace Tyuiu.MakarovAY.Sprint3.Task5.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Макаров А. Я. | РППБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Макаров А. Я. | РППБ-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму сумм ряда по формуле        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue1 = 1; int stopValue1 = 3 ;
            int startValue2 = 1; int stopValue2 = 6;
            int x = 5;


            Console.WriteLine("* Старт шага первой суммы ряда = " + startValue1);
            Console.WriteLine("* Конец шага первой суммы ряда = " + stopValue1);
            Console.WriteLine("* Старт шага второй суммы ряда = " + startValue2);
            Console.WriteLine("* Конец шага второй суммы ряда = " + stopValue2);
            Console.WriteLine("* Переменная Х = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Число = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadKey();

        }
    }
}
