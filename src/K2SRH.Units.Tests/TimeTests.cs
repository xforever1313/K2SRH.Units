namespace K2SRH.Units.Tests
{
    [TestClass]
    public sealed class TimeTests
    {
        // ---------------- Tests ----------------

        [TestMethod]
        public void ConvertTo1DayTest()
        {
            // Setup
            TimeSpan expected = new TimeSpan( 1, 0, 0, 0 );

            // Act / Check
            Assert.AreEqual( expected, new Microseconds( 86400000000 ) );
            Assert.AreEqual( expected, new Milliseconds( 86400000 ) );
            Assert.AreEqual( expected, new Seconds( 86400 ) );
            Assert.AreEqual( expected, new Minutes( 1440 ) );
            Assert.AreEqual( expected, new Hours( 24 ) );
            Assert.AreEqual( expected, new Days( 1 ) );
            Assert.AreEqual( expected, new Weeks( 1m / 7m ) );
        }

        [TestMethod]
        public void ConvertTo1HourTest()
        {
            // Setup
            TimeSpan expected = new TimeSpan( 1, 0, 0 );

            // Act / Check
            Assert.AreEqual( expected, new Microseconds( 3600000000 ) );
            Assert.AreEqual( expected, new Milliseconds( 3600000 ) );
            Assert.AreEqual( expected, new Seconds( 3600 ) );
            Assert.AreEqual( expected, new Minutes( 60 ) );
            Assert.AreEqual( expected, new Hours( 1 ) );
            Assert.AreEqual( expected, new Days( 1m / 24m ) );
            Assert.AreEqual( expected, new Weeks( 1m / 7m / 24m ) );
        }
    }
}
