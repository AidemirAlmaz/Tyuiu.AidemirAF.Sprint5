using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.IO;

namespace Tyuiu.AidemirAF.Sprint5.Task7.V5.Lib
{
    public class DataService : ISprint5Task7V5
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\DataSprint5\InPutDataFileTask7V5.txt";
            Directory.CreateDirectory(Path.GetDirectoryName(pathSaveFile)); // Создаем директорию, если ее нет

            if (!File.Exists(path))
            {
                Console.WriteLine($"Ошибка: Файл по пути '{path}' не найден.");
                return null; // Или другое значение для обозначения ошибки
            }

            // Создаем выходной файл и записываем в него очищенные данные
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string strLine = "";
                    foreach (char c in line)
                    {
                        if (!char.IsLetter(c) || !((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')))
                        {
                            strLine += c;
                        }
                    }
                }
            }
            return pathSaveFile;
        }
    }
}