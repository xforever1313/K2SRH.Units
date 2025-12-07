using System;

namespace K2SRH.Units
{
    [Unit( typeof( TimeSpan ) )]
    public partial struct Seconds
    {
        // ---------------- Constructor ----------------

        public static implicit operator TimeSpan( Seconds seconds )
        {
            return new TimeSpan( decimal.ToInt64( TimeSpan.TicksPerSecond * seconds.Value ) );
        }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value.ToStringRemoveNonSignificantDigits()} seconds";
        }
    }

    public static partial class SecondsExtensions
    {
        /// <remarks>
        /// Internal since the generator needs this, but <see cref="TimeSpan"/>
        /// already has <see cref="TimeSpan.Seconds"/>, so we don't want this public
        /// to prevent confusion with <see cref="TimeSpan.Seconds"/>.
        /// </remarks>
        internal static decimal Seconds( TimeSpan seconds )
        {
            return new decimal( seconds.Ticks ) / new decimal( TimeSpan.TicksPerSecond );
        }

        public static decimal TotalSecondsAsDecimal( this TimeSpan seconds )
        {
            return Seconds( seconds );
        }
    }
}
