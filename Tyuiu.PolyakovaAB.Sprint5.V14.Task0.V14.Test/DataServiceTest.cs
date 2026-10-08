using Mono.Cecil;
using Tyuiu.PolyakovaAB.Sprint5.V14.Task0.V14.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
namespace Tyuiu.PolyakovaAB.Sprint5.V14.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string path = Path.Combine("C:\\", "Users", "Арина", "source", "repos", "Tyuiu.PolyakovaAB.Sprint5", "outPutFileTask0.txt"); ;
            FileInfo fileinfo = new FileInfo(path);
            bool wait = true;
            Assert.AreEqual(wait, fileinfo.Exists);
        }
    }
}
