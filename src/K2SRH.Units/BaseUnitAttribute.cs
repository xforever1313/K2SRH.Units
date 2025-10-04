using System;

namespace K2SRH.Units
{
    /// <summary>
    /// Used by the generator to detect when to generate the common-things between all base-level units.
    /// </summary>
    [AttributeUsage( AttributeTargets.Struct, AllowMultiple = false, Inherited = false )]
    internal class BaseUnitAttribute : Attribute
    {
    }
}
