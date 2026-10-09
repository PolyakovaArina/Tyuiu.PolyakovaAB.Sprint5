using Tyuiu.PolyakovaAB.Sprint5.Task1.V24.Lib;
namespace Tyuiu.PolyakovaAB.Sprint5.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string path = Path.Combine("C:\\", "Users", "Арина", "source", "repos", "Tyuiu.PolyakovaAB.Sprint5", "outPutFileTask1.txt"); ;
            FileInfo fileinfo = new FileInfo(path);
            bool wait = true;
            Assert.AreEqual(wait, fileinfo.Exists);
        }
    }
}
