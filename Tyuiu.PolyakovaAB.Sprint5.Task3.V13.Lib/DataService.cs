using System.Text;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PolyakovaAB.Sprint5.Task2.V13.Lib
{
    public class DataService : ISprint5Task3V13
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            double y = Math.Round((x / (Math.Pow(x, 3) + 2)), 3);
            using (BinaryWriter w = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                w.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}
