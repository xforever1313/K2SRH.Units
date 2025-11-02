//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units
{
    [Unit( typeof( Distance ) )]
    public partial struct Kilometers
    {
        // ---------------- Constructor ----------------

        public static implicit operator Distance( Kilometers km )
        {
            return new Distance( km.Value * 1000.0m );
        }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value} km";
        }
    }

    public static partial class KilometersExtensions
    {
        public static decimal Kilometers( this Distance distance )
        {
            return distance.Meters / 1000.0m;
        }
    }
}
