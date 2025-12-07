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
            string result = RemoveExtraSpaces(text);

            // Сохраняем во временную папку с правами доступа
            string outPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V27.txt");
            File.WriteAllText(outPath, result);

            return outPath;
        }

        private string RemoveExtraSpaces(string text)
        {
            StringBuilder sb = new StringBuilder();
            bool lastWasSpace = false;

            foreach (char c in text)
            {
                if (c == ' ')
                {
                    if (!lastWasSpace)
                    {
                        sb.Append(c);
                        lastWasSpace = true;
                    }
                }
                else
                {
                    sb.Append(c);
                    lastWasSpace = false;
                }
            }

            return sb.ToString();
        }
    }
}
