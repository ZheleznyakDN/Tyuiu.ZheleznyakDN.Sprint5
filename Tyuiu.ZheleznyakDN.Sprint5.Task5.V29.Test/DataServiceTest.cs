using Tyuiu.ZheleznyakDN.Sprint5.Task5.V29.Lib;
using System.IO;

namespace Tyuiu.ZheleznyakDN.Sprint5.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string directory = @"C:\Users\Дамир\source\repos\Tyuiu.ZheleznyakDN.Sprint5\Sprint5Task5";
            string fileName = "InPutDataFileTask5V29.txt";
            string path = Path.Combine(directory, fileName);

            if (!File.Exists(path))
            {
                Directory.CreateDirectory(directory);
                File.WriteAllText(path, "5 9 18 -0.48 18.17 12 11 -4.71 -5.7 18 -3.92 -4 -1.03 9 8.08 2.78 8.76 -9.75 -3 -4");
            }

            double result = ds.LoadFromDataFile(path);

            Assert.AreEqual(-10, result);
        }
    }
}
