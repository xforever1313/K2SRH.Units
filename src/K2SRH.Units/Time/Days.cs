using System;

namespace K2SRH.Units
{
    [Unit( typeof( TimeSpan ) )]
    public partial struct Days
    {
        // ---------------- Constructor ----------------

        public static implicit operator TimeSpan( Days days )
        {
            return new TimeSpan( decimal.ToInt64( TimeSpan.TicksPerDay * days.Value ) );
        }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value.ToStringRemoveNonSignificantDigits()} days";
        }
    }

    public static partial class DaysExtensions
    {
        /// <remarks>
        /// Internal since the generator needs this, but <see cref="TimeSpan"/>
        /// already has <see cref="TimeSpan.Days"/>, so we don't want this public
        /// to prevent confusion with <see cref="TimeSpan.Days"/>.
        /// </remarks>
        internal static decimal Days( TimeSpan days )
        {
            return new decimal( days.Ticks ) / new decimal( TimeSpan.TicksPerDay );
        }

        public static decimal TotalDaysAsDecimal( this TimeSpan days )
        {
            return Days( days );
        }
    }
}
