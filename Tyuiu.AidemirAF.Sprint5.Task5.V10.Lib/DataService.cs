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
                string line;
                string inputString = "14 18 15 3.76 8.53 9.56 -4.52 -10 15.29 17 7 7 7 -7.09 5.29 11.48 -1 -3.81 17.08 -7.56"; 
                double sum = 0;
                string[] numberStrings = inputString.Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string numberString in numberStrings)
                {
                    if (double.TryParse(numberString, out double number))
                    {
                        if (number % 2 == 0)
                        {
                            sum += number;
                        }
                    }
                    else
                    {
                        // Обработка случая, если строка не может быть преобразована в число (можно пропустить или вывести сообщение об ошибке)
                        //Console.WriteLine($"Не удалось преобразовать '{numberString}' в число.");
                    }
                }
                return sum;
            }
        }
    }
}
