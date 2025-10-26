//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

using System;

namespace K2SRH.Units
{
    [Measurement]
    public partial struct Frequency
    {
        // ---------------- Constructor ----------------

        public Frequency( decimal hertz )
        {
            this.value = hertz;
        }

        // ---------------- Properties ----------------

        public decimal Hertz => this.value;

        // ---------------- Methods ----------------

        public override string ToString()
        {
            if( this < new KiloHertz( 1 ) )
            {
                return this.ToHertz().ToString();
            }
            else if( this < new MegaHertz( 1 ) )
            {
                return this.ToKiloHertz().ToString();
            }
            else if( this < new GigaHertz( 1 ) )
            {
                return this.ToMegaHertz().ToString();
            }
            else
            {
                return this.ToGigaHertz().ToString();
            }
        }
    }
}
