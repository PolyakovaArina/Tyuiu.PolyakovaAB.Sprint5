using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PolyakovaAB.Sprint5.Task0.V14.Lib
{
    public class DataService : ISprint5Task0V14
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\outPutFileTask0.txt";
            
            double y = Math.Round((4 * Math.Pow(x, 3))/(Math.Pow(x, 3) - 1),3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
