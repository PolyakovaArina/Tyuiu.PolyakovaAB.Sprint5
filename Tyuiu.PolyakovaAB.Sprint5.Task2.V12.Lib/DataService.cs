using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PolyakovaAB.Sprint5.Task2.V12.Lib

{
    public class DataService : ISprint5Task2V12
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool Fe = fileInfo.Exists;
            if (Fe)
            {
                File.Delete(path);
            }
            int r = matrix.GetUpperBound(0) + 1;
            int c = matrix.Length/r;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string s = "";
            for (int i = 0;i < r; i++)
            {
                for (int j = 0;j < c; j++)
                {
                    if (j != c - 1)
                    {
                        s = s + matrix[i, j] + ";";
                    }
                    else
                    {
                        s = s + matrix[i, j];
                    }
                }
                if (i != r - 1)
                {
                    File.AppendAllText(path, s + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, s);
                }
                s = "";
            }
            return path;
            
        }
    }
}
