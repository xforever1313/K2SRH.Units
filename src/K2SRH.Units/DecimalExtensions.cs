//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units
{
    internal static class DecimalExtensions
    {
        public static string ToStringRemoveNonSignificantDigits( this decimal value )
        {
            return value.ToString( "G29" );
        }
    }
}
