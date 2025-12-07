using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZheleznyakDN.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            string[] numbers = content.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int? minTwoDigit = null;

            foreach (string numStr in numbers)
            {
                double value = Convert.ToDouble(
                    numStr.Replace(',', '.'),
                    CultureInfo.InvariantCulture);

                int rounded = (int)Math.Round(value);

                if (Math.Abs(rounded) >= 10 && Math.Abs(rounded) <= 99)
                {
                    if (minTwoDigit == null || rounded < minTwoDigit.Value)
                        minTwoDigit = rounded;
                }
            }

            return minTwoDigit ?? 0;
        }
    }
}
