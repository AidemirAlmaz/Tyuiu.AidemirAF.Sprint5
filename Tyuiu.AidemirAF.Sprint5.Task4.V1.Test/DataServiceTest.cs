using Tyuiu.AidemirAF.Sprint5.Task4.V1.Lib;

namespace Tyuiu.AidemirAF.Sprint5.Task4.V1.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
