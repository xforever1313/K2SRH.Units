using System;

namespace K2SRH.Units
{
    [Unit( typeof( TimeSpan ) )]
    public partial struct Microseconds
    {
        // ---------------- Constructor ----------------

        public static implicit operator TimeSpan( Microseconds us )
        {
            return new TimeSpan( decimal.ToInt64( ( TimeSpan.TicksPerMillisecond / 1000 ) * us.Value ) );
        }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value.ToStringRemoveNonSignificantDigits()} \u03BC";
        }
    }

    public static partial class MicrosecondsExtensions
    {
        /// <remarks>
        /// Internal since the generator needs this, but for <see cref="TimeSpan"/>
        /// we use "Total" for the unit methods as there are existing properties
        /// that just give out that portion of the time span, which we don't want.
        /// </remarks>
        internal static decimal Microseconds( TimeSpan us )
        {
            return new decimal( us.Ticks ) / new decimal( TimeSpan.TicksPerMillisecond / 1000 );
        }

        public static decimal TotalWeeksAsDecimal( this TimeSpan us )
        {
            return Microseconds( us );
        }
    }
}
