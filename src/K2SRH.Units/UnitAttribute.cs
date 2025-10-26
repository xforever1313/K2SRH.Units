using System;

namespace K2SRH.Units
{

    /// <summary>
    /// Used by the generator to detect a unit that a particular measurement can use.
    /// </summary>
    [AttributeUsage( AttributeTargets.Struct, AllowMultiple = true, Inherited = false )]
    public sealed class UnitAttribute : Attribute
    {
        // ---------------- Constructor ----------------

        public UnitAttribute( Type type )
        {
            this.MeasurementType = type;
        }

        // ---------------- Properties ----------------

        /// <summary>
        /// What measurement can use this unit.
        /// </summary>
        public Type MeasurementType { get; }
    }
}
