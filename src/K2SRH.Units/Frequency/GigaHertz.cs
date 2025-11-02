//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units
{
    [Unit( typeof( Frequency ) )]
    public partial struct GigaHertz
    {
        // ---------------- Constructor ----------------

        public static implicit operator Frequency( GigaHertz gigaHertz )
        {
            return new Frequency( gigaHertz.Value * 1000.0m * 1000m * 1000m );
        }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value} GHz";
        }
    }

    public static partial class GigaHertzExtensions
    {
        public static decimal GigaHertz( this Frequency frequency )
        {
            return frequency.Hertz / ( 1000m * 1000m * 1000m );
        }
    }
}
