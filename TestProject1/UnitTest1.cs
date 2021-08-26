using NUnit.Framework;
using LambdaUsingList;

namespace TestProject1
{
    public class Tests
    {
        Operation operation;

        [SetUp]
        public void Setup()
        {
            operation = new Operation();
        }

        [Test]
        public void FindAllTest()
        {
            bool output = operation.Findall();

            Assert.IsTrue(output);
        }

        [Test]
        public void TeenagerOrNotTest()
        {
            bool output = operation.TeenagerOrNot();

            Assert.IsTrue(output);
        }

        [Test]
        public void AverageTest()
        {
            double output = operation.Average();

            Assert.AreEqual(output,operation.Average());
        }

        
        [Test]
        public void FindNameTest()
        {
            bool output = operation.GetName();

            Assert.IsTrue(output);
        }
    }
}