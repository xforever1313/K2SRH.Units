namespace K2SRH.Units
{
    [Unit( typeof( Frequency ) )]
    public struct GigaHertz
    {
        // ---------------- Constructor ----------------

        public GigaHertz( decimal gigaHertz )
        {
            this.Value = gigaHertz;
        }

        public static implicit operator Frequency( GigaHertz gigaHertz )
        {
            return new Frequency( gigaHertz.Value * 1000.0m * 1000m * 1000m );
        }

        // ---------------- Properties ----------------

        public decimal Value { get; }

        // ---------------- Methods ----------------

        public override string ToString()
        {
            return $"{this.Value} GHz";
        }
    }

    public static class GigaHertzExtensions
    {
        public static decimal GigaHertz( this Frequency frequency )
        {
            return frequency.Hertz / ( 1000m * 1000m * 1000m );
        }

        public static GigaHertz ToGigaHertz( this Frequency frequency )
        {
            return new GigaHertz( frequency.GigaHertz() );
        }
    }
}
