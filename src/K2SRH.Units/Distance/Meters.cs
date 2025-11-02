//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units
{
    [Unit( typeof( Distance ) )]
    public partial struct Meters
    {
        // ---------------- Constructor ----------------

        public static implicit operator Distance( Meters meters )
        {
            return new Distance( meters.Value );
        }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value.ToStringRemoveNonSignificantDigits()} m";
        }
    }

    public static partial class MetersExtensions
    {
        /// <remarks>
        /// Internal to have the property be used instead.
        /// Only here so it works with the generator.
        /// </remarks>
        internal static decimal Meters( this Distance distance )
        {
            return distance.Meters;
        }
    }
}
