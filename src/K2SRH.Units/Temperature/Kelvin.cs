//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units
{
    public struct Kelvin
    {
        // ---------------- Constructor ----------------

        public Kelvin( decimal kelvin )
        {
            this.Value = kelvin;
        }

        public static implicit operator Temperature( Kelvin hertz )
        {
            return new Temperature( hertz.Value );
        }

        // ---------------- Properties ----------------

        public decimal Value { get; }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value}K";
        }
    }

    public static class KelvinExtensions
    {
        public static Kelvin ToKelvin( this Temperature temperature )
        {
            return new Kelvin( temperature.Kelvin );
        }
    }
}
