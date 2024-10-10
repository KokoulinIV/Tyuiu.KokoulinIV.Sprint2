using Tyuiu.KokoulinIV.Sprint2.Task2.V19.Lib;
namespace Tyuiu.KokoulinIV.Sprint2.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            

            Console.Title = "Спринт #2 | Выполнил Кокоулин И. В. | ИБКСб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Кокоулин Иван Владимирович   | ИБКСб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y                       *");
            Console.WriteLine("* в заштрихованной области                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Значение Х");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значение Y");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат:");
            Console.WriteLine(ds.CheckDotInShadedArea(x, y));
            Console.ReadKey();
        }
    }
}
