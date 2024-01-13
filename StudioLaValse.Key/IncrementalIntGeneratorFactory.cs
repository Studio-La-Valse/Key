namespace StudioLaValse.Key
{
    public class IncrementalIntGeneratorFactory : IKeyGeneratorFactory<int>
    {
        public IKeyGenerator<int> CreateKeyGenerator()
        {
            return new IncrementalIntGenerator();
        }
    }
}
