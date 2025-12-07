using System;

namespace K2SRH.Units
{
    [Unit( typeof( TimeSpan ) )]
    public partial struct Hours
    {
        // ---------------- Constructor ----------------

        public static implicit operator TimeSpan( Hours hours )
        {
            return new TimeSpan( decimal.ToInt64( TimeSpan.TicksPerHour * hours.Value ) );
        }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value.ToStringRemoveNonSignificantDigits()} hours";
        }
    }

    public static partial class HoursExtensions
    {
        /// <remarks>
        /// Internal since the generator needs this, but <see cref="TimeSpan"/>
        /// already has <see cref="TimeSpan.Hours"/>, so we don't want this public
        /// to prevent confusion with <see cref="TimeSpan.Hours"/>.
        /// </remarks>
        internal static decimal Hours( TimeSpan hours )
        {
            return new decimal( hours.Ticks ) / new decimal( TimeSpan.TicksPerHour );
        }

        public static decimal TotalHoursAsDecimal( this TimeSpan hours )
        {
            return Hours( hours );
        }
    }
}
