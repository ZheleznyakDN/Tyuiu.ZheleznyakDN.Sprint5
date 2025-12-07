using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZheleznyakDN.Sprint5.Task6.V7.Lib
{
    public class DataService : ISprint5Task6V7
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;

            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден по пути: {path}");
            }


            string text = File.ReadAllText(path);

            foreach (char c in text)
            {

                if (c >= 'a' && c <= 'z')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
