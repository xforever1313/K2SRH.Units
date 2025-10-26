//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

using System;

namespace K2SRH.Units
{
    /// <summary>
    /// Used by the generator to detect when to generate the common-things between all measurement types.
    /// </summary>
    [AttributeUsage( AttributeTargets.Struct, AllowMultiple = false, Inherited = false )]
    internal class MeasurementAttribute : Attribute
    {
    }
}
