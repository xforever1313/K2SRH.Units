//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

using System.Runtime.InteropServices;

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
        public void MultiplyMeasurementByScalerTest()
        {
            // Setup
            Frequency f1 = new KiloHertz( 1 );

            // Act
            Frequency actualFreq = f1 * 3;

            // Check
            Assert.AreEqual( new KiloHertz( 3m ), actualFreq );
            Assert.AreEqual( new Hertz( 3000m ), actualFreq );
            Assert.AreEqual( new MegaHertz( 0.003m ), actualFreq );
            Assert.AreEqual( new GigaHertz( 0.000003m ), actualFreq );
        }

        [TestMethod]
        public void MultiplyScalerByMeasurementTest()
        {
            // Setup
            Frequency f1 = new KiloHertz( 1 );

            // Act
            Frequency actualFreq = 3 * f1;

            // Check
            Assert.AreEqual( new KiloHertz( 3m ), actualFreq );
            Assert.AreEqual( new Hertz( 3000m ), actualFreq );
            Assert.AreEqual( new MegaHertz( 0.003m ), actualFreq );
            Assert.AreEqual( new GigaHertz( 0.000003m ), actualFreq );
        }

        [TestMethod]
        public void DivideTest()
        {
            // Setup
            Frequency f1 = new GigaHertz( 1 );

            // Act
            Frequency actualFreq = f1 / 2m;

            // Check
            Assert.AreEqual( new GigaHertz( 0.5m ), actualFreq );
            Assert.AreEqual( new MegaHertz( 500m ), actualFreq );
            Assert.AreEqual( new KiloHertz( 500000m ), actualFreq );
            Assert.AreEqual( new Hertz( 500000000m ), actualFreq );
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
        public void MinTest()
        {
            // Setup
            Frequency f1 = new GigaHertz( -1 );
            Frequency f2 = new GigaHertz( 0 );
            Frequency f3 = new MegaHertz( 1 );

            // Act
            Frequency minF1AndF2 = Frequency.Min( f1, f2 );
            Frequency minF2AndF3 = Frequency.Min( f2, f3 );
            Frequency minF1AndF3 = Frequency.Min( f1, f3 );

            // Check
            Assert.AreEqual( f1, minF1AndF2 );
            Assert.AreEqual( f2, minF2AndF3 );
            Assert.AreEqual( f1, minF1AndF3 );
        }

        [TestMethod]
        public void MaxTest()
        {
            // Setup
            Frequency f1 = new GigaHertz( -1 );
            Frequency f2 = new GigaHertz( 0 );
            Frequency f3 = new MegaHertz( 1 );

            // Act
            Frequency maxF1AndF2 = Frequency.Max( f1, f2 );
            Frequency maxF2AndF3 = Frequency.Max( f2, f3 );
            Frequency maxF1AndF3 = Frequency.Max( f1, f3 );

            // Check
            Assert.AreEqual( f2, maxF1AndF2 );
            Assert.AreEqual( f3, maxF2AndF3 );
            Assert.AreEqual( f3, maxF1AndF3 );
        }

        [TestMethod]
        public void ToDoubleTest()
        {
            // Setup
            Frequency ghz = new GigaHertz( 1.5m );
            Frequency mhz = new MegaHertz( 2.25m );
            Frequency khz = new KiloHertz( 3.7m );
            Frequency hz = new Hertz( 0 );

            // Act
            double actualGhz = ghz.GigaHertzAsDouble();
            double actualMhz = mhz.MegaHertzAsDouble();
            double actualKhz = khz.KiloHertzAsDouble();
            double actualHz = hz.HertzAsDouble();

            // Check
            Assert.AreEqual( 1.5, actualGhz );
            Assert.AreEqual( 2.25, actualMhz );
            Assert.AreEqual( 3.7, actualKhz );
            Assert.AreEqual( 0, actualHz );
        }

        [TestMethod]
        public void ToInt32Test()
        {
            // Setup
            Frequency ghz = new GigaHertz( 1.5m );
            Frequency mhz = new MegaHertz( 2.25m );
            Frequency khz = new KiloHertz( 3.7m );
            Frequency hz = new Hertz( 0 );

            // Act
            int actualGhz = ghz.GigaHertzAsInt32();
            int actualMhz = mhz.MegaHertzAsInt32();
            int actualKhz = khz.KiloHertzAsInt32();
            int actualHz = hz.HertzAsInt32();

            // Check
            Assert.AreEqual( 1, actualGhz );
            Assert.AreEqual( 2, actualMhz );
            Assert.AreEqual( 3, actualKhz );
            Assert.AreEqual( 0, actualHz );
        }

        [TestMethod]
        public void IsWholeUnitTest()
        {
            // Setup
            Frequency fractGhz = new GigaHertz( 1.5m );
            Frequency fractMhz = new MegaHertz( 2.25m );
            Frequency fractKhz = new KiloHertz( 3.7m );
            Frequency fractHz = new Hertz( 0.8m );

            Frequency wholeGhz = new GigaHertz( -1 );
            Frequency wholeMhz = new MegaHertz( 2 );
            Frequency wholeKhz = new KiloHertz( 3 );
            Frequency wholeHz = new Hertz( 0 );

            // Act / Check
            Assert.IsFalse( fractGhz.IsWholeGigaHertz() );
            Assert.IsFalse( fractMhz.IsWholeMegaHertz() );
            Assert.IsFalse( fractKhz.IsWholeKiloHertz() );
            Assert.IsFalse( fractHz.IsWholeHertz() );

            Assert.IsTrue( wholeGhz.IsWholeGigaHertz() );
            Assert.IsTrue( wholeMhz.IsWholeMegaHertz() );
            Assert.IsTrue( wholeKhz.IsWholeKiloHertz() );
            Assert.IsTrue( wholeHz.IsWholeHertz() );
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

        [TestMethod]
        public void RoundDownToNearestWithDefaultSettingsTest()
        {
            Frequency startingHz = new Hertz( 10.01m );
            Frequency startingKHz = new KiloHertz( 10.1m );
            Frequency startingMHz = new MegaHertz( 10.3m );
            Frequency startingGHz = new GigaHertz( 10.2m );

            Assert.AreEqual( new Hertz( 10m ), startingHz.RoundToNearestHertz() );
            Assert.AreEqual( Frequency.Zero, startingHz.RoundToNearestGigaHertz() );
            Assert.AreEqual( new KiloHertz( 10m ), startingKHz.RoundToNearestKiloHertz() );
            Assert.AreEqual( new MegaHertz( 10m ), startingMHz.RoundToNearestMegaHertz() );
            Assert.AreEqual( new GigaHertz( 10m ), startingGHz.RoundToNearestGigaHertz() );
        }

        [TestMethod]
        public void RoundDownToNearestWithDecimalsSpecified()
        {
            Frequency startingHz = new Hertz( 10.0104m );
            Frequency startingKHz = new KiloHertz( 10.0101m );
            Frequency startingMHz = new MegaHertz( 10.0103m );
            Frequency startingGHz = new GigaHertz( 10.0102m );

            Assert.AreEqual( new Hertz( 10.01m ), startingHz.RoundToNearestHertz( 2 ) );
            Assert.AreEqual( Frequency.Zero, startingHz.RoundToNearestGigaHertz( 2 ) );
            Assert.AreEqual( new KiloHertz( 10.01m ), startingKHz.RoundToNearestKiloHertz( 2 ) );
            Assert.AreEqual( new MegaHertz( 10.01m ), startingMHz.RoundToNearestMegaHertz( 2 ) );
            Assert.AreEqual( new GigaHertz( 10.01m ), startingGHz.RoundToNearestGigaHertz( 2 ) );
        }

        [TestMethod]
        public void RoundUpToNearestWithDefaultSettingsTest()
        {
            Frequency startingHz = new Hertz( 10.51m );
            Frequency startingKHz = new KiloHertz( 10.61m );
            Frequency startingMHz = new MegaHertz( 10.73m );
            Frequency startingGHz = new GigaHertz( 10.82m );

            Assert.AreEqual( new Hertz( 11m ), startingHz.RoundToNearestHertz() );
            Assert.AreEqual( Frequency.Zero, startingHz.RoundToNearestGigaHertz() );
            Assert.AreEqual( new KiloHertz( 11m ), startingKHz.RoundToNearestKiloHertz() );
            Assert.AreEqual( new MegaHertz( 11m ), startingMHz.RoundToNearestMegaHertz() );
            Assert.AreEqual( new GigaHertz( 11m ), startingGHz.RoundToNearestGigaHertz() );
        }

        [TestMethod]
        public void RoundUpToNearestWithDecimalsSpecified()
        {
            Frequency startingHz = new Hertz( 10.016m );
            Frequency startingKHz = new KiloHertz( 10.017m );
            Frequency startingMHz = new MegaHertz( 10.018m );
            Frequency startingGHz = new GigaHertz( 10.019m );

            Assert.AreEqual( new Hertz( 10.02m ), startingHz.RoundToNearestHertz( 2 ) );
            Assert.AreEqual( Frequency.Zero, startingHz.RoundToNearestGigaHertz( 2 ) );
            Assert.AreEqual( new KiloHertz( 10.02m ), startingKHz.RoundToNearestKiloHertz( 2 ) );
            Assert.AreEqual( new MegaHertz( 10.02m ), startingMHz.RoundToNearestMegaHertz( 2 ) );
            Assert.AreEqual( new GigaHertz( 10.02m ), startingGHz.RoundToNearestGigaHertz( 2 ) );
        }

        [TestMethod]
        public void MidpointRoundToNearestWithDefaultSettingsTest()
        {
            Frequency startingHz = new Hertz( 10.5m );
            Frequency startingKHz = new KiloHertz( 10.5m );
            Frequency startingMHz = new MegaHertz( 10.5m );
            Frequency startingGHz = new GigaHertz( 10.5m );

            // 10 is the even number.  It will round to that.
            Assert.AreEqual( new Hertz( 10m ), startingHz.RoundToNearestHertz() );
            Assert.AreEqual( Frequency.Zero, startingHz.RoundToNearestGigaHertz() );
            Assert.AreEqual( new KiloHertz( 10m ), startingKHz.RoundToNearestKiloHertz() );
            Assert.AreEqual( new MegaHertz( 10m ), startingMHz.RoundToNearestMegaHertz() );
            Assert.AreEqual( new GigaHertz( 10m ), startingGHz.RoundToNearestGigaHertz() );
        }

        [TestMethod]
        public void MidpointAwayFromZeroRoundToNearestWithDefaultSettingsTest()
        {
            Frequency startingHz = new Hertz( 10.5m );
            Frequency startingKHz = new KiloHertz( 10.5m );
            Frequency startingMHz = new MegaHertz( -10.5m );
            Frequency startingGHz = new GigaHertz( 10.5m );

            // 11 is further from zero,It will round to that.
            Assert.AreEqual( new Hertz( 11m ), startingHz.RoundToNearestHertz( MidpointRounding.AwayFromZero ) );
            Assert.AreEqual( Frequency.Zero, startingHz.RoundToNearestGigaHertz( MidpointRounding.AwayFromZero ) );
            Assert.AreEqual( new KiloHertz( 11m ), startingKHz.RoundToNearestKiloHertz( MidpointRounding.AwayFromZero ) );
            Assert.AreEqual( new MegaHertz( -11m ), startingMHz.RoundToNearestMegaHertz( MidpointRounding.AwayFromZero ) );
            Assert.AreEqual( new GigaHertz( 11m ), startingGHz.RoundToNearestGigaHertz( MidpointRounding.AwayFromZero ) );
        }

        [TestMethod]
        public void MidpointAwayFromZeroRoundUpToNearestWithDecimalsSpecified()
        {
            Frequency startingHz = new Hertz( 10.015m );
            Frequency startingKHz = new KiloHertz( 10.015m );
            Frequency startingMHz = new MegaHertz( -10.015m );
            Frequency startingGHz = new GigaHertz( 10.015m );

            Assert.AreEqual( new Hertz( 10.02m ), startingHz.RoundToNearestHertz( 2, MidpointRounding.AwayFromZero ) );
            Assert.AreEqual( Frequency.Zero, startingHz.RoundToNearestGigaHertz( 2, MidpointRounding.AwayFromZero ) );
            Assert.AreEqual( new KiloHertz( 10.02m ), startingKHz.RoundToNearestKiloHertz( 2, MidpointRounding.AwayFromZero ) );
            Assert.AreEqual( new MegaHertz( -10.02m ), startingMHz.RoundToNearestMegaHertz( 2, MidpointRounding.AwayFromZero ) );
            Assert.AreEqual( new GigaHertz( 10.02m ), startingGHz.RoundToNearestGigaHertz( 2, MidpointRounding.AwayFromZero ) );
        }
    }
}
