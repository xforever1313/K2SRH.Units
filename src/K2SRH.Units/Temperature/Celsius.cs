//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units
{
    public struct Celsius
    {
        // ---------------- Constructor ----------------

        public Celsius( decimal celsius )
        {
            this.Value = celsius;
        }

        public static implicit operator Temperature( Celsius celsius )
        {
            return new Temperature( celsius.Value + 273.15m );
        }

        // ---------------- Properties ----------------

        public decimal Value { get; }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value}°C";
        }
    }

    public static class CelsiusExtensions
    {
        public static decimal Celsius( this Temperature temperature )
        {
            return temperature.Kelvin - 273.15m;
        }

        public static Celsius ToCelsius( this Temperature temperature )
        {
            return new Celsius( temperature.Celsius() );
        }
    }
}
