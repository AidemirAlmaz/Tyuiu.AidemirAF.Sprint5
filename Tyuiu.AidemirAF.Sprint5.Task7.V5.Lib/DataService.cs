using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.IO;
using System.Linq;

namespace Tyuiu.AidemirAF.Sprint5.Task7.V5.Lib
{
    public class DataService : ISprint5Task7V5
    {
        public string LoadDataAndSave(string inputFilePath)
        {
            // Validate input path
            if (string.IsNullOrEmpty(inputFilePath) || !File.Exists(inputFilePath))
            {
                Console.WriteLine($"Error: Input file not found or path is invalid: {inputFilePath}");
                return null;
            }

            // Output file path.  Make sure the directory exists!
            string outputFilePath = Path.Combine(Path.GetDirectoryName(inputFilePath), "OutputDataFileTask7V5.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(outputFilePath));


            try
            {
                // Read and process the input file.
                string[] lines = File.ReadAllLines(inputFilePath);
                string[] outputLines = lines.Select(line =>
                {
                    return new string(line.Where(c => !char.IsLetter(c) || !((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))).ToArray());
                }).ToArray();

                // Delete the output file if it already exists.
                if (File.Exists(outputFilePath))
                {
                    File.Delete(outputFilePath);
                }

                // Write the processed lines to the output file.
                File.WriteAllLines(outputFilePath, outputLines);
                return outputFilePath;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error processing file: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                return null;
            }
        }
    }
}