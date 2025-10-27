using Tyuiu.MakarovAY.Sprint3.Task3.V27.Lib;
namespace Tyuiu.MakarovAY.Sprint3.Task3.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Макаров А. Я. | РППБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Макаров А. Я. | РППБ-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach удалить все буквы и знаки препинания, оставить   *");
            Console.WriteLine("* цифру затем преобразовать в число в строке: !bt, g567kid f!             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "!bt, g567kid f!";

            Console.WriteLine("Исходная строка = " + value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Число = " + ds.ConvertStringToInt(value));
            Console.ReadKey();

        }
    }
}
