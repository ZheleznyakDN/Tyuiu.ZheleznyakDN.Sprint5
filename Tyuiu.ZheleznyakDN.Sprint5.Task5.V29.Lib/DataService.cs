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

            int minTwoDigit = int.MaxValue;
            bool found = false;

            foreach (string numStr in numbers)
            {
                double number = Convert.ToDouble(
                    numStr.Replace(',', '.'),
                    CultureInfo.InvariantCulture);

                int intNumber = (int)Math.Round(number);

                if (intNumber >= 10 && intNumber <= 99)
                {
                    if (!found || intNumber < minTwoDigit)
                    {
                        minTwoDigit = intNumber;
                        found = true;
                    }
                }
            }

            if (!found)
                return 0;

            return minTwoDigit;
        }
    }
}
