using System.IO;
using Tyuiu.ZheleznyakDN.Sprint5.Task6.V7.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint5.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Hello, Мир! Это Is My First Program.");
            }

            DataService ds = new DataService();

            int result = ds.LoadFromDataFile(path);

            File.Delete(path);

            Assert.AreEqual(16, result);
        }
    }
}
