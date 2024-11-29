using System.Globalization;
using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint5;
    
namespace Tyuiu.AidemirAF.Sprint5.Task5.V10.Lib
{
    public class DataService : ISprint5Task5V10
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                {
                    string[] lines = File.ReadAllLines(path);

                    foreach (string line in lines)
                    {
                        string[] numberStrings = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries); // Разделение строки на числа

                        foreach (string numberString in numberStrings)
                        {
                            if (double.TryParse(numberString, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                            {
                                if (number % 2 == 0)
                                {
                                    res += number;
                                }
                            }
                        }
                    }
                }
            }
            return res;
        }
    }
}
