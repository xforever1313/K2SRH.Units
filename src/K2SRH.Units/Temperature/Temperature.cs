//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units
{
    [BaseUnit]
    public partial struct Temperature
    {
        // ---------------- Fields ----------------

        public static readonly Temperature AbsoluteZero = new Kelvin( 0 );

        public static readonly Temperature WaterFreezePoint = new Celsius( 0 );

        public static readonly Temperature WaterBoilingPoint = new Celsius( 100 );

        // ---------------- Constructor ----------------

        public Temperature( decimal kelvin )
        {
            this.value = kelvin;
        }

        // ---------------- Properties ----------------

        public decimal Kelvin => this.value;

        // ---------------- Methods ----------------

        public override string ToString()
        {
            // Yeah, an American wrote this.
            return this.ToFahrenheit().ToString();
        }
    }
}
