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
            return base.ToString();
        }
    }
}
