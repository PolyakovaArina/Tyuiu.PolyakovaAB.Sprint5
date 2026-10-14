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
                    string a1 = Convert.ToString(line);
                    string a2 = a1.Replace(".", ",");
                    double a = Convert.ToDouble(a2);
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
