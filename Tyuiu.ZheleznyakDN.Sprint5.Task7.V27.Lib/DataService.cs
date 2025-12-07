using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZheleznyakDN.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            string text = File.ReadAllText(path);
            string result = RemoveAllSpaces(text);

            string outPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V27.txt");
            File.WriteAllText(outPath, result);

            return outPath;
        }

        private string RemoveAllSpaces(string text)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in text)
            {
                if (c != ' ')
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}
