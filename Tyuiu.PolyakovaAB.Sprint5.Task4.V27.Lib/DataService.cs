using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PolyakovaAB.Sprint5.Task4.V27.Lib
{
    public class DataService : ISprint5Task4V27
    {
        public double LoadFromDataFile(string path)
        {
            double x = Convert.ToDouble(File.ReadAllText(path));
            double y = Math.Round((Math.Pow(x, 3) - 4 * x) / Math.Cos(x), 3);
            return y;
        }
    }
}
