//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units
{
    [Unit( typeof( Frequency ) )]
    public partial struct KiloHertz
    {
        // ---------------- Constructor ----------------

        public static implicit operator Frequency( KiloHertz kiloHertz )
        {
            return new Frequency( kiloHertz.Value * 1000.0m );
        }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value} KHz";
        }
    }

    public static partial class KiloHertzExtensions
    {
        public static decimal KiloHertz( this Frequency frequency )
        {
            return frequency.Hertz / 1000m;
        }
    }
}
