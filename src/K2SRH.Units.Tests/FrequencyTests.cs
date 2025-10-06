//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units.Tests
{
    [TestClass]
    public sealed class FrequencyTests
    {
        // ---------------- Tests ----------------

        [TestMethod]
        public void AddTest()
        {
            // Setup
            Frequency f1 = new Hertz( 100 );
            Frequency f2 = new Hertz( 200 );

            // Act
            Frequency actualFreq = f1 + f2;

            // Check
            Assert.AreEqual( new Frequency( 300 ), actualFreq );
            Assert.AreEqual( new Hertz( 300 ) , actualFreq );
            Assert.AreEqual( new KiloHertz( 0.3m ), actualFreq );
            Assert.AreEqual( new MegaHertz( 0.0003m ), actualFreq );
            Assert.AreEqual( new GigaHertz( 0.0000003m ), actualFreq );
        }

        [TestMethod]
        public void SubtractTest()
        {
            // Setup
            Frequency f1 = new KiloHertz( 1 );
            Frequency f2 = new Hertz( 200 );

            // Act
            Frequency actualFreq = f1 - f2;

            // Check
            Assert.AreEqual( new Frequency( 800 ), actualFreq );
            Assert.AreEqual( new Hertz( 800 ), actualFreq );
            Assert.AreEqual( new KiloHertz( 0.8m ), actualFreq );
            Assert.AreEqual( new MegaHertz( 0.0008m ), actualFreq );
            Assert.AreEqual( new GigaHertz( 0.0000008m ), actualFreq );
        }

        [TestMethod]
        public void MultiplyTest()
        {
            // Setup
            Frequency f1 = new KiloHertz( 1 );
            Frequency f2 = new KiloHertz( 1 );

            // Act
            Frequency actualFreq = f1 * f2;

            // Check
            Assert.AreEqual( new Frequency( 1000000 ), actualFreq );
            Assert.AreEqual( new Hertz( 1000000 ), actualFreq );
            Assert.AreEqual( new KiloHertz( 1000 ), actualFreq );
            Assert.AreEqual( new MegaHertz( 1 ), actualFreq );
            Assert.AreEqual( new GigaHertz( 0.001m ), actualFreq );
        }

        [TestMethod]
        public void DivideTest()
        {
            // Setup
            Frequency f1 = new GigaHertz( 1 );
            Frequency f2 = new MegaHertz( 500 );

            // Act
            Frequency actualFreq = f1 / f2;

            // Check
            Assert.AreEqual( new Frequency( 2 ), actualFreq );
            Assert.AreEqual( new Hertz( 2 ), actualFreq );
            Assert.AreEqual( new KiloHertz( 0.002m ), actualFreq );
            Assert.AreEqual( new MegaHertz( 0.000002m ), actualFreq );
            Assert.AreEqual( new GigaHertz( 0.000000002m ), actualFreq );

            Assert.AreEqual( new Hertz( 2 ), actualFreq );
        }

        [TestMethod]
        public void LessThanGreaterThanTest()
        {
            // Setup
            Frequency f1 = new KiloHertz( 5 );
            Frequency f2 = new KiloHertz( 4 );

            // Check
            Assert.IsTrue( f1 > f2 );
            Assert.IsTrue( f1 >= f2 );
            Assert.IsFalse( f1 < f2 );
            Assert.IsFalse( f1 <= f2 );
        }

        [TestMethod]
        public void EqualsTest()
        {
            // Setup
            Frequency f1 = new KiloHertz( 5 );
            Frequency f2 = new Hertz( 5000 );
            Frequency f3 = new KiloHertz( 4 );

            // Check
            Assert.IsFalse( f1.Equals( "Hello" ) );
            Assert.IsTrue( f1.Equals( f2 ) );
            Assert.IsTrue( f2.Equals( f1 ) );
            Assert.IsTrue( f1 == f2 );
            Assert.IsFalse( f1 != f2 );
            Assert.IsTrue( f1 <= f2 );
            Assert.IsTrue( f1 >= f2 );

            Assert.IsFalse( f1.Equals( f3 ) );
            Assert.IsFalse( f3.Equals( f1 ) );
            Assert.IsFalse( f1 == f3 );
            Assert.IsTrue( f1 != f3 );
            Assert.IsFalse( f1 <= f3 );
            Assert.IsTrue( f1 >= f3 );
        }

        [TestMethod]
        public void AbsTest()
        {
            // Setup
            Frequency f1 = new GigaHertz( -1 );
            Frequency f2 = new MegaHertz( 500 );

            // Act
            Frequency actualF1 = Frequency.Abs( f1 );
            Frequency actualF2 = Frequency.Abs( f2 );

            // Check
            Assert.AreEqual( new GigaHertz( 1 ), actualF1 );
            Assert.AreEqual( new GigaHertz( 0.5m ), actualF2 );
        }

        [TestMethod]
        public void ToStringTest()
        {
            void DoTest( Frequency freq, string expectedString )
            {
                Assert.AreEqual( expectedString, freq.ToString() );
            }

            DoTest( new Hertz( 1 ), "1 Hz" );
            DoTest( new Hertz( 100 ), "100 Hz" );
            DoTest( new Hertz( 999.999m ), "999.999 Hz" );

            DoTest( new Hertz( 1000 ), "1 KHz" );
            DoTest( new KiloHertz( 999 ), "999.0 KHz" );

            DoTest( new KiloHertz( 1000 ), "1.0 MHz" );
            DoTest( new MegaHertz( 1 ), "1.0 MHz" );
            DoTest( new MegaHertz( 999 ), "999.0 MHz" );

            DoTest( new MegaHertz( 1000 ), "1.0 GHz" );
            DoTest( new GigaHertz( 2 ), "2.0 GHz" );
        }
    }
}
