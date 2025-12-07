using Tyuiu.ZheleznyakDN.Sprint5.Task5.V29.Lib;
using System.IO;

namespace Tyuiu.ZheleznyakDN.Sprint5.Task5.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Задание #5 | Вариант 29 | Железняк Д.Н. | ПКТб-25-1";
            Console.WriteLine("*************************************************************");
            Console.WriteLine("* Спринт #5                                                 *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла            *");
            Console.WriteLine("* Задание #5.5                                              *");
            Console.WriteLine("* Вариант #29                                               *");
            Console.WriteLine("*************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                  *");
            Console.WriteLine("* Дан файл InPutDataFileTask5V29.txt с набором значений.    *");
            Console.WriteLine("* Найти минимальное целое число в файле, которое является   *");
            Console.WriteLine("* двузначным.                                               *");
            Console.WriteLine("*************************************************************");

            string directory = @"C:\Users\Дамир\source\repos\Tyuiu.ZheleznyakDN.Sprint5\Sprint5Task5";
            string fileName = "InPutDataFileTask5V29.txt";
            string path = Path.Combine(directory, fileName);

            Console.WriteLine($"Путь к файлу: {path}");
            Console.WriteLine("*************************************************************");

            try
            {
                double result = ds.LoadFromDataFile(path);
                Console.WriteLine($"Минимальное двузначное число: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.WriteLine("Убедитесь, что файл существует по указанному пути.");
            }

            Console.WriteLine("*************************************************************");
            Console.WriteLine("* Работа программы завершена.                               *");
            Console.ReadKey();

        }
    }
}
