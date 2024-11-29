using Tyuiu.AidemirAF.Sprint5.Task5.V10.Lib;

namespace Tyuiu.AidemirAF.Sprint5.Task5.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V10.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Сумма четных элементов файла = " + res);
            Console.ReadKey();
        }
    }
}
