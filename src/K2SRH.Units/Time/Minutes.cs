using System;

namespace K2SRH.Units
{
    [Unit( typeof( TimeSpan ) )]
    public partial struct Minutes
    {
        // ---------------- Constructor ----------------

        public static implicit operator TimeSpan( Minutes minutes )
        {
            return new TimeSpan( decimal.ToInt64( TimeSpan.TicksPerMinute * minutes.Value ) );
        }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value.ToStringRemoveNonSignificantDigits()} minutes";
        }
    }

    public static partial class MinutesExtensions
    {
        /// <remarks>
        /// Internal since the generator needs this, but <see cref="TimeSpan"/>
        /// already has <see cref="TimeSpan.Minutes"/>, so we don't want this public
        /// to prevent confusion with <see cref="TimeSpan.Minutes"/>.
        /// </remarks>
        internal static decimal Minutes( TimeSpan minutes )
        {
            return new decimal( minutes.Ticks ) / new decimal( TimeSpan.TicksPerMinute );
        }

        public static decimal TotalMinutesAsDecimal( this TimeSpan minutes )
        {
            return Minutes( minutes );
        }
    }
}
