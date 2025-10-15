//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units
{
    public struct Rankine
    {
        // ---------------- Constructor ----------------

        public Rankine( decimal rankine )
        {
            this.Value = rankine;
        }

        public static implicit operator Temperature( Rankine rankine )
        {
            return new Fahrenheit( rankine.Value - 459.67m );
        }

        // ---------------- Properties ----------------

        public decimal Value { get; }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value}°R";
        }
    }

    public static class RankineExtensions
    {
        public static decimal Rankine( this Temperature temperature )
        {
            return temperature.Fahrenheit() + 459.67m;
        }

        public static Rankine ToRankine( this Temperature temperature )
        {
            return new Rankine( temperature.Rankine() );
        }
    }
}
