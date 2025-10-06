namespace K2SRH.Units
{
    public struct MegaHertz
    {
        // ---------------- Constructor ----------------

        public MegaHertz( decimal megaHertz )
        {
            this.Value = megaHertz;
        }

        public static implicit operator Frequency( MegaHertz megaHertz )
        {
            return new Frequency( megaHertz.Value * 1000.0m * 1000m );
        }

        // ---------------- Properties ----------------

        public decimal Value { get; }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value} MHz";
        }
    }

    public static class MegaHertzExtensions
    {
        public static decimal MegaHertz( this Frequency frequency )
        {
            return frequency.Hertz / ( 1000m * 1000m );
        }

        public static MegaHertz ToMegaHertz( this Frequency frequency )
        {
            return new MegaHertz( frequency.MegaHertz() );
        }
    }
}
