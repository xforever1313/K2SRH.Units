//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units
{
    [Measurement]
    public partial struct Distance
    {
        // ---------------- Constructor ----------------

        public Distance( decimal meters )
        {
            this.value = meters;
        }

        // ---------------- Properties ----------------

        public decimal Meters => this.value;

        // ---------------- Methods ----------------

        public override string ToString()
        {
            if( this < new Millimeters( 1 ) )
            {
                return this.ToMicrometers().ToString();
            }
            else if( this < new Centimeters( 1 ) )
            {
                return this.ToMillimeters().ToString();
            }
            else if( this < new Meters( 1 ) )
            {
                return this.ToCentimeters().ToString();
            }
            else if( this < new Kilometers( 1 ) )
            {
                return this.ToMeters().ToString();
            }
            else
            {
                return this.ToKilometers().ToString();
            }
        }
    }
}
