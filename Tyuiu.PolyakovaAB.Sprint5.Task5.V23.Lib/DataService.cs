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
                    double a = Convert.ToDouble(line);
                    if (a < res)
                    {
                        res = a;
                    }
                }
            }
            return res;
        }
    }
}
