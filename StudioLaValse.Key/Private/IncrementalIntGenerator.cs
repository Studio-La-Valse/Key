namespace StudioLaValse.Key
{
    internal class IncrementalIntGenerator : IKeyGenerator<int>
    {
        private int count = 0;

        public IncrementalIntGenerator()
        {
            
        }

        public int Generate()
        {
            var number = count;
            count++;
            return number;
        }
    }
}
