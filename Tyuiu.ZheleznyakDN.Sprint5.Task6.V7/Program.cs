using System.IO;
using Tyuiu.ZheleznyakDN.Sprint5.Task6.V7.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint5.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Железняк Д.Н. | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Железняк Дамир Николаевич | ПКТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных.                       *");
            Console.WriteLine("* Найти количество строчных латинских букв в заданной строке.            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string directory = @"C:\Users\Дамир\source\repos\Tyuiu.ZheleznyakDN.Sprint5\Sprint5Task6";
            string fileName = "InPutDataFileTask6V7.txt";
            string path = Path.Combine(directory, fileName);

            Console.WriteLine("Путь к файлу: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                DataService ds = new DataService();
                int count = ds.LoadFromDataFile(path);

                Console.WriteLine("Количество строчных латинских букв в файле: " + count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка при обработке файла: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
