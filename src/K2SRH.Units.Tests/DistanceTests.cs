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
        public void ConversionToMetersTests()
        {
            Distance um = new Micrometers( 1 );
            Distance mm = new Millimeters( 1 );
            Distance cm = new Centimeters( 1 );
            Distance inch = new Inches( 1 );
            Distance meters = new Meters( 1 );
            Distance km = new Kilometers( 1 );

            Assert.AreEqual( new Meters( 0.000001m ), um );
            Assert.AreEqual( new Meters( 0.001m ), mm );
            Assert.AreEqual( new Meters( 0.01m ), cm );
            Assert.AreEqual( new Meters( 0.0254m ), inch );
            Assert.AreEqual( new Meters( 1 ), meters );
            Assert.AreEqual( new Meters( 1000m ),km );
        }

        [TestMethod]
        public void ConversionToInchesTests()
        {
            Distance meter = new Meters( 1 );

            Assert.AreEqual( new Inches( 39.37007874015748031496062992126m ), meter );
        }

        [TestMethod]
        public void ToStringTest()
        {
            void DoTest( Distance distance, string expectedString )
            {
                Assert.AreEqual( expectedString, distance.ToString() );
            }

            DoTest( new Micrometers( 1 ), "1 μm" );
            DoTest( new Micrometers( 1000 ), "1 mm" );

            DoTest( new Millimeters( 1 ), "1 mm" );
            DoTest( new Millimeters( 1000 ), "1 m" );

            DoTest( new Centimeters( 1 ), "1 cm" );
            DoTest( new Centimeters( 99.99m ), "99.99 cm" );
            DoTest( new Centimeters( 100 ), "1 m" );

            DoTest( new Meters( 1 ), "1 m" );
            DoTest( new Meters( 100 ), "100 m" );
            DoTest( new Meters( 999.999m ), "999.999 m" );

            DoTest( new Meters( 1000 ), "1 km" );
            DoTest( new Kilometers( 1 ), "1 km" );
        }
    }
}
