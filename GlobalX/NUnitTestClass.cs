using NUnit.Framework;
using System;
namespace GlobalX
{
    [TestFixture()]
    public class NUnitTestClass
    {
        [Test()]
        public void TestCase()
        {
			Console.WriteLine("Please enter file path: ");
			string filePath = Console.ReadLine();

            if (filePath.Equals("") || !filePath.Contains(".txt"))
            {
                Assertion.Assert();
            }
        }
    }
}