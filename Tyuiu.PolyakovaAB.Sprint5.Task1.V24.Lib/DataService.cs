using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PolyakovaAB.Sprint5.Task1.V24.Lib
{
    public class DataService : ISprint5Task1V24
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "outPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fe = fileInfo.Exists;
            if (fe)
            {
                fileInfo.Delete();
            }
            double y;
            string sy;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = Math.Round((3 * Math.Cos(i)) / (4 * i - 0.5) + Math.Sin(i) - 5 * i - 2, 2);
                sy = Convert.ToString(y);
                if (i != stopValue)
                {
                    File.AppendAllText(path, sy + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, sy);
                }
            }
            return path;
        }
    }
}
