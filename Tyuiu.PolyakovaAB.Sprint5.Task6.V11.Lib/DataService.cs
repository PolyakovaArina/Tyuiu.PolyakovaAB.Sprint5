using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PolyakovaAB.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(new char[] { ' ', '\t','.',',' ,'!','?'});
                    foreach (string part in parts)
                    {
                        string a = part;
                        if (a.Length == 6)
                        {
                            res ++;
                        }
                    }
                }
            }
            return res;
        }
    }
}
