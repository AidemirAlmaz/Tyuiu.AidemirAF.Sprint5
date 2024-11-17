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
            string path = @"C:\Users\Honor\source\repos\Tyuiu.AidemirAF.Sprint5\Tyuiu.AidemirAF.Sprint5.Task0.V8\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}