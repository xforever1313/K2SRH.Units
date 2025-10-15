//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units.Tests
{
    [TestClass]
    public sealed class TemperatureTests
    {
        // ---------------- Tests ----------------

        [TestMethod]
        public void CelsiusFreezingWaterTest()
        {
            Temperature freezing = new Celsius( 0 );

            Assert.AreEqual( freezing, new Fahrenheit( 32 ) );
            Assert.AreEqual( freezing, new Rankine( 491.67m ) );
            Assert.AreEqual( freezing, new Kelvin( 273.15m ) );
        }

        [TestMethod]
        public void CelsiusBoilingWaterTest()
        {
            Temperature boiling = new Celsius( 100 );

            Assert.AreEqual( boiling, new Fahrenheit( 212 ) );
            Assert.AreEqual( boiling, new Rankine( 671.641m ) );
            Assert.AreEqual( boiling, new Kelvin( 373.15m ) );
        }

        [TestMethod]
        public void CelsiusFortyBelowTest()
        {
            Temperature fortyBelow = new Celsius( -40 );

            Assert.AreEqual( fortyBelow, new Fahrenheit( -40 ) );
            Assert.AreEqual( fortyBelow, new Rankine( 419.67m ) );
            Assert.AreEqual( fortyBelow, new Kelvin( 233.15m ) );
        }

        [TestMethod]
        public void FahrenheitFreezingWaterTest()
        {
            Temperature freezing = new Fahrenheit( 32 );

            Assert.AreEqual( freezing, new Celsius( 0 ) );
            Assert.AreEqual( freezing, new Rankine( 491.67m ) );
            Assert.AreEqual( freezing, new Kelvin( 273.15m ) );
        }

        [TestMethod]
        public void FahrenheitBoilingWaterTest()
        {
            Temperature boiling = new Fahrenheit( 212 );

            Assert.AreEqual( boiling, new Celsius( 100 ) );
            Assert.AreEqual( boiling, new Rankine( 671.641m ) );
            Assert.AreEqual( boiling, new Kelvin( 373.15m ) );
        }

        [TestMethod]
        public void FahrenheitFortyBelowTest()
        {
            Temperature fortyBelow = new Fahrenheit( -40 );

            Assert.AreEqual( fortyBelow, new Celsius( -40 ) );
            Assert.AreEqual( fortyBelow, new Rankine( 419.67m ) );
            Assert.AreEqual( fortyBelow, new Kelvin( 233.15m ) );
        }
    }
}