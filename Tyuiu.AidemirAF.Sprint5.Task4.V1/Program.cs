using Tyuiu.AidemirAF.Sprint5.Task4.V1.Lib;

namespace Tyuiu.AidemirAF.Sprint5.Task4.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            string path = $@"{Path.GetTempPath()}InPutFileTask4.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Файл:" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
