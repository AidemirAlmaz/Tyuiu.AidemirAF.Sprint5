using System.IO; // для использования класса файл
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AidemirAF.Sprint5.Task0.V8.Lib
{
    public class DataService : ISprint5Task0V8
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Path.GetTempPath()}\OutPutFileTask0.txt";
            double y = Math.Round((Math.Pow(x, 3) - 1) / 4 * Math.Pow(x, 2), 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
