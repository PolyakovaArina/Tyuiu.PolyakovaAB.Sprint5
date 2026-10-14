using Tyuiu.PolyakovaAB.Sprint5.Task7.V2.Lib;
namespace Tyuiu.PolyakovaAB.Sprint5.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string path = @"C:\Users\Арина\source\repos\Tyuiu.PolyakovaAB.Sprint5\OutPutFileTask2.csv";
            FileInfo fi = new FileInfo(path);
            bool Fe = fi.Exists;
            bool w = true;
            Assert.AreEqual(w, Fe);
        }
    }
}
