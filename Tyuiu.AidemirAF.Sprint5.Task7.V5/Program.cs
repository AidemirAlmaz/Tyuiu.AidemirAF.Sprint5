using Tyuiu.AidemirAF.Sprint5.Task7.V5.Lib;

namespace Tyuiu.AidemirAF.Sprint5.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V5.txt";
            string pathSaveFile = @"C:\DataSprint5\InPutDataFileTask7V5.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
