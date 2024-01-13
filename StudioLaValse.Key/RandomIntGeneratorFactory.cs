namespace StudioLaValse.Key
{
    public class RandomIntGeneratorFactory : IKeyGeneratorFactory<int>
    {
        public IKeyGenerator<int> CreateKeyGenerator()
        {
            return new RandomIntGenerator();
        }
    }
}
