namespace StudioLaValse.Key
{
    internal class IntGenerator : IKeyGenerator<int>
    {
        private readonly int value;

        public IntGenerator(int value)
        {
            this.value = value;
        }

        public int Generate()
        {
            return value;
        }
    }
}
