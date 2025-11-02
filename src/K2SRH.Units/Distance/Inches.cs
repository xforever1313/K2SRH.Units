//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units
{
    [Unit( typeof( Distance ) )]
    public partial struct Inches
    {
        // ---------------- Constructor ----------------

        public static implicit operator Distance( Inches inch )
        {
            return new Distance( inch.Value * 0.0254m );
        }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value.ToStringRemoveNonSignificantDigits()} in";
        }
    }

    public static partial class InchesExtensions
    {
        public static decimal Inches( this Distance distance )
        {
            return distance.Meters / 0.0254m;
        }
    }
}
