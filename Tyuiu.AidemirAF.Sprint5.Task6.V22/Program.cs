using Tyuiu.AidemirAF.Sprint5.Task6.V22.Lib;

namespace Tyuiu.AidemirAF.Sprint5.Task6.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V22.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество удвоенных букв \"мм\" = " + res);
            Console.ReadKey();
        }
    }
}
