using Tyuiu.AidemirAF.Sprint5.Task2.V21.Lib;

namespace Tyuiu.AidemirAF.Sprint5.Task2.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { 
                { 4, 8, 5 },
                { 6, 3, 2 },
                { 9, 4, 5 } };
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            string res = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Файл:" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
