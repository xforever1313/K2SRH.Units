namespace K2SRH.Units
{
    [BaseUnit]
    public partial struct Frequency
    {
        // ---------------- Fields ----------------

        private readonly decimal value;

        // ---------------- Constructor ----------------

        public Frequency( decimal hertz )
        {
            this.value = hertz;
        }

        // ---------------- Properties ----------------

        public decimal Hertz => this.value;
    }
}
