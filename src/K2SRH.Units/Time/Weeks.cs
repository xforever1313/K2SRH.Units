using System;

namespace K2SRH.Units
{
    /// <summary>
    /// A week is defined by 7 days.
    /// </summary>
    [Unit( typeof( TimeSpan ) )]
    public partial struct Weeks
    {
        // ---------------- Constructor ----------------

        public static implicit operator TimeSpan( Weeks weeks )
        {
            return new TimeSpan( decimal.ToInt64( ( TimeSpan.TicksPerDay * 7 ) * weeks.Value ) );
        }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value.ToStringRemoveNonSignificantDigits()} weeks";
        }
    }

    public static partial class WeeksExtensions
    {
        /// <remarks>
        /// Internal since the generator needs this, but for <see cref="TimeSpan"/>
        /// we use "Total" for the unit methods as there are existing properties
        /// that just give out that portion of the time span, which we don't want.
        /// </remarks>
        internal static decimal Weeks( TimeSpan weeks )
        {
            return new decimal( weeks.Ticks ) / new decimal( TimeSpan.TicksPerDay * 7 );
        }

        public static decimal TotalWeeksAsDecimal( this TimeSpan seconds )
        {
            return Weeks( seconds );
        }
    }
}
