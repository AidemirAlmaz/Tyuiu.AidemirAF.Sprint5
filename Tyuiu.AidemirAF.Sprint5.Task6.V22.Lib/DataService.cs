using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AidemirAF.Sprint5.Task6.V22.Lib
{
    public class DataService : ISprint5Task6V22
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using StreamReader reader = new StreamReader(path);
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int index = line.IndexOf("мм");
                    while (index != -1)
                    {
                        count++;
                        index = line.IndexOf("мм", index + 1);
                    }
                }
            }
            return count;
        }
    }
}
