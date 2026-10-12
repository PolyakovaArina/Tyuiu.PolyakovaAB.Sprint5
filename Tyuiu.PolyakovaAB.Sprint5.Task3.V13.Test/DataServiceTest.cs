using Tyuiu.PolyakovaAB.Sprint5.Task2.V13.Lib;
namespace Tyuiu.PolyakovaAB.Sprint5.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Арина\source\repos\Tyuiu.PolyakovaAB.Sprint5\OutPutFileTask2.csv";
            FileInfo fi = new FileInfo(path);
            bool Fe = fi.Exists;
            bool w = true;
            Assert.AreEqual(w, Fe);
        }
    }
}
