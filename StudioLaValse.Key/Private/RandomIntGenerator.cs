namespace StudioLaValse.Key
{
    internal class RandomIntGenerator : IKeyGenerator<int>
    {
        public RandomIntGenerator()
        {
            
        }

        public int Generate()
        {
            return Random.Shared.Next();
        }
    }
}
