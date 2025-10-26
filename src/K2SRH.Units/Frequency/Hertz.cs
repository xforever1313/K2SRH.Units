//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units
{
    [Unit( typeof( Frequency ) )]
    public partial struct Hertz
    {
        // ---------------- Constructor ----------------

        public static implicit operator Frequency( Hertz hertz )
        {
            return new Frequency( hertz.Value );
        }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value} Hz";
        }
    }

    public static partial class HertzExtensions
    {
        /// <remarks>
        /// Internal to have the property be used instead.
        /// Only here so it works with the generator.
        /// </remarks>
        internal static decimal Hertz( this Frequency frequency )
        {
            return frequency.Hertz;
        }
    }
}
