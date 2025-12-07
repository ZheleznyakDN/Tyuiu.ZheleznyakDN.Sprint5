using System.IO;
using Tyuiu.ZheleznyakDN.Sprint5.Task7.V27.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint5.Task7.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string tempDir = Path.GetTempPath();
            string inputPath = Path.Combine(tempDir, "InPutDataFileTask7V27.txt");

            File.WriteAllText(inputPath, "Это  строка  с  пробелами");

            DataService ds = new DataService();
            string outPath = ds.LoadDataAndSave(inputPath);

            string result = File.ReadAllText(outPath);
            string expected = "Это строка с пробелами";

            Assert.AreEqual(expected, result);
        }
    }
}
