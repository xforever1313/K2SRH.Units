namespace K2SRH.Units.Tests
{
    [TestClass]
    public sealed class FrequencyTests
    {
        [TestMethod]
        public void AddTest()
        {
            Frequency f = new Frequency();
            Frequency f2 = new Frequency();

            Frequency f3 = f + f2;
        }
    }
}
