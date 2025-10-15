//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units
{
    public struct Fahrenheit
    {
        // ---------------- Constructor ----------------

        public Fahrenheit( decimal fahrenheit )
        {
            this.Value = fahrenheit;
        }

        public static implicit operator Temperature( Fahrenheit fahrenheit )
        {
            // K = ( F + 459.67 )× 5/9
            return new Temperature( ( fahrenheit.Value + 459.67m ) * ( 5.0m/9.0m ) );
        }

        // ---------------- Properties ----------------

        public decimal Value { get; }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value}°F";
        }
    }

    public static class FahrenheitExtensions
    {
        public static decimal Fahrenheit( this Temperature temperature )
        {
            // F = (K - 273.15) × 9/5 + 32
            return ( ( temperature.Kelvin - 273.15m ) * ( 9.0m / 5.0m ) ) + 32;
        }

        public static Fahrenheit ToFahrenheit( this Temperature temperature )
        {
            return new Fahrenheit( temperature.Fahrenheit() );
        }
    }
}
