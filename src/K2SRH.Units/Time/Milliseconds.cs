using System;
using System.Collections.Generic;
using System.Text;

namespace K2SRH.Units
{
    [Unit( typeof( TimeSpan ) )]
    public partial struct Milliseconds
    {
        // ---------------- Constructor ----------------

        public static implicit operator TimeSpan( Milliseconds ms )
        {
            return new TimeSpan( decimal.ToInt64( TimeSpan.TicksPerMillisecond * ms.Value ) );
        }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value.ToStringRemoveNonSignificantDigits()} ms";
        }
    }

    public static partial class MillisecondsExtensions
    {
        /// <remarks>
        /// Internal since the generator needs this, but <see cref="TimeSpan"/>
        /// already has <see cref="TimeSpan.Milliseconds"/>, so we don't want this public
        /// to prevent confusion with <see cref="TimeSpan.Milliseconds"/>.
        /// </remarks>
        internal static decimal Milliseconds( TimeSpan ms )
        {
            return new decimal( ms.Ticks ) / new decimal( TimeSpan.TicksPerMillisecond );
        }

        public static decimal TotalMillisecondsAsDecimal( this TimeSpan ms )
        {
            return Milliseconds( ms );
        }
    }
}
