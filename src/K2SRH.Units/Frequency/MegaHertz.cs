﻿namespace K2SRH.Units
{
    [Unit( typeof( Frequency ) )]
    public partial struct MegaHertz
    {
        // ---------------- Constructor ----------------

        public static implicit operator Frequency( MegaHertz megaHertz )
        {
            return new Frequency( megaHertz.Value * 1000.0m * 1000m );
        }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value} MHz";
        }
    }

    public static partial class MegaHertzExtensions
    {
        public static decimal MegaHertz( this Frequency frequency )
        {
            return frequency.Hertz / ( 1000m * 1000m );
        }
    }
}
