namespace K2SRH.Units
{
    public struct KiloHertz
    {
        // ---------------- Constructor ----------------

        public KiloHertz( decimal kiloHertz )
        {
            this.Value = kiloHertz;
        }

        public static implicit operator Frequency( KiloHertz kiloHertz )
        {
            return new Frequency( kiloHertz.Value * 1000.0m );
        }

        // ---------------- Properties ----------------

        public decimal Value { get; }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value} KHz";
        }
    }

    public static class KiloHertzExtensions
    {
        public static decimal KiloHertz( this Frequency frequency )
        {
            return frequency.Hertz / 1000m;
        }

        public static KiloHertz ToKiloHertz( this Frequency frequency )
        {
            return new KiloHertz( frequency.KiloHertz() );
        }
    }
}
