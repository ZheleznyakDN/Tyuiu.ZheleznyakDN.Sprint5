using System.IO;
using Tyuiu.ZheleznyakDN.Sprint5.Task7.V27.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint5.Task7.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Железняк Д.Н. | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Железняк Дамир Николаевич | ПКТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Удалить лишние пробелы и сохранить результат в файл                     *");
            Console.WriteLine("***************************************************************************");

            string directory = @"C:\Users\Дамир\source\repos\Tyuiu.ZheleznyakDN.Sprint5\Sprint5Task7";
            string fileName = "InPutDataFileTask7V27.txt";
            string path = Path.Combine(directory, fileName);

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл: " + path);

            DataService ds = new DataService();
            string resultPath = ds.LoadDataAndSave(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл сохранен: " + resultPath);

            Console.ReadKey();
        }
    }
}
