//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units.Tests
{
    [TestClass]
    public sealed class DistanceTests
    {
        // ---------------- Tests ----------------

        [TestMethod]
        public void ConversionTests()
        {
            Distance um = new Micrometers( 1 );
            Distance mm = new Millimeters( 1 );
            Distance cm = new Centimeters( 1 );
            Distance meters = new Meters( 1 );
            Distance km = new Kilometers( 1 );

            Assert.AreEqual( new Meters( 0.000001m ), um );
            Assert.AreEqual( new Meters( 0.001m ), mm );
            Assert.AreEqual( new Meters( 0.01m ), cm );
            Assert.AreEqual( new Meters( 1 ), meters );
            Assert.AreEqual( new Meters( 1000m ),km );
        }
    }
}
