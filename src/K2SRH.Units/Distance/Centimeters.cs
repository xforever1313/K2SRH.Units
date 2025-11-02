//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units
{
    [Unit( typeof( Distance ) )]
    public partial struct Centimeters
    {
        // ---------------- Constructor ----------------

        public static implicit operator Distance( Centimeters cm )
        {
            return new Distance( cm.Value / 100.0m );
        }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value} cm";
        }
    }

    public static partial class CentimetersExtensions
    {
        public static decimal Centimeters( this Distance distance )
        {
            return distance.Meters * 100.0m;
        }
    }
}
