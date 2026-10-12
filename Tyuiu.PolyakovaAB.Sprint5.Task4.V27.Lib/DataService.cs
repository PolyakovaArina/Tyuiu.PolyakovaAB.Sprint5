using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PolyakovaAB.Sprint5.Task4.V27.Lib
{
    public class DataService : ISprint5Task4V27
    {
        public double LoadFromDataFile(string path)
        {
            string x = (File.ReadAllText(path));
            string x1 = x.Replace(".", ",");
            double x2 = Convert.ToDouble(x1);
            double y = Math.Round((Math.Pow(x2, 3) - 4 * x2) / Math.Cos(x2), 3);
            return y;
        }
    }
}
