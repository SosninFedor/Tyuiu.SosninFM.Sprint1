
using Tyuiu.SosninFM.Sprint1.Task3.V13.Lib;

//ЗАДАНИЕ 
// Написать программу, которая позволяет найти произведение цифр заданного трехзначного числа.
// Ответ округлите до 3 знаков после запятой.

namespace Tyuiu.SosninFM.Sprint1.Task3.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Соснин Ф. М. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Соснин Фёдор Михайлович | АСОиУб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле (5*x)/(y+x) и печатает его на экране     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double number;
            Console.WriteLine("Введите значение number:");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение цифр трехзначного числа = " + ds.MultiplyOfDigits(number));
            Console.ReadLine();



        }
    }
}
