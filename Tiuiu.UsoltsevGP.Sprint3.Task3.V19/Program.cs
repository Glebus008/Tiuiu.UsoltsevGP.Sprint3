using Tiuiu.UsoltsevGP.Sprint3.Task3.V19.Lib;
namespace Tyuiu.UsoltsevGP.Sprint3.Task1.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Усольцев Г. П. | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Усольцев Глеб Павлович | РППб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы x на цифру 2                      *");
            Console.WriteLine("* в строке: sxxrrg x vfrx                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "sxxrrg x vfrx";
            char replaceable = 'x';
            char replacement = '2';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Заменяемый символ = " + replaceable);
            Console.WriteLine("Заменяющий символ = " + replacement);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Итоговая строка = " + ds.ReplaceCharOnNum(value, replaceable, replacement));
            Console.ReadKey();
        }
    }
}