using System;
using Tyuiu.AidemirAF.Sprint5.Task0.V8.Lib;

namespace Tyuiu.AidemirAF.Sprint5.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string directory = @"C:\Users\“»”\source\repos\Tyuiu.AidemirAF.Sprint5\Tyuiu.AidemirAF.Sprint5.Task0.V8\bin\Debug";
            string file = "OutPutFileTask0.txt";
            string path = Path.Combine(directory, file);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}