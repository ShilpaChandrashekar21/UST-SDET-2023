namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [OneTimeSetUp]
        public void Init()
        {
            Console.WriteLine("Set up");
        }
        [Test]
        public void Test1()
        {
            Console.WriteLine("Test1 method");
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void Test2()
        {
            Console.WriteLine("Test2 method");
            Assert.AreEqual(1, 1);
        }
        [OneTimeTearDown]
        public void Close()
        {
            Console.WriteLine("Closed");
        }
    }


}


