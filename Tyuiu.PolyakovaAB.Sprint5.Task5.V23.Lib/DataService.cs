using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PolyakovaAB.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            double res = 100;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(new char[] { ' ', '\t' });
                    foreach (string part in parts)
                    {
                        double a = double.Parse(part.Replace('.', ','));
                        if (a < res & a%1!=0)
                        {
                            res = a;
                        }
                    }
                }
            }
            return res;
        }
    }
}
