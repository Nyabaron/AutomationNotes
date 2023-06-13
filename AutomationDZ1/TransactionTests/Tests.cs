using TestProject1;

namespace TransactionTests
{
    [TestFixture]
    internal class Tests
    {
        Transaction Transaction { get; set; }

        [SetUp]
        public void Preconditions()
        {
            Transaction = new Transaction();
        }

        [Test]
        [Category("Positive tests")]
        [TestCaseSource(typeof(TestData), nameof(TestData.NewTestData))]              
        public void Test1(double remittance, double expectedResult)
        {
            var actualResult = Transaction.FullSumm(remittance);
            Assert.True(actualResult == expectedResult);
        }

        [Test]
        [Category("Out of range")]
        [TestCase(9)]
        [TestCase(10001)]
        public void Test2(double remittance)
        {
            try
            {
                var actualResult = Transaction.FullSumm(remittance);
            }
            catch (ArgumentException e)
            {
                Assert.True(e.Message == ("Remittance should be from 10 to 10000"));
            }
        }

        
    }
}
