using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AidemirAF.Sprint5.Task4.V1.Lib
{
    public class DataService : ISprint5Task4V1
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Replace(".", ",");
            double res = Math.Round(1/(Math.Cos(Convert.ToDouble(strX)) + Convert.ToDouble(strX)) ,3);
            return res;
        }
    }
}
