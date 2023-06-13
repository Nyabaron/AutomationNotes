namespace TransactionTests
{
    internal class TestData
    {
        public static IEnumerable<TestCaseData> NewTestData()
        {
            yield return new TestCaseData(10, 11);
            yield return new TestCaseData(999, 1098.9);
            yield return new TestCaseData(1000, 1050);
            yield return new TestCaseData(9999, 10498.95);
            yield return new TestCaseData(10000, 10100);
        }
    }
}
