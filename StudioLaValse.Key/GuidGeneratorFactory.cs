namespace StudioLaValse.Key
{
    public class GuidGeneratorFactory : IKeyGeneratorFactory<Guid>
    {
        public IKeyGenerator<Guid> CreateKeyGenerator()
        {
            return new GuidGenerator();
        }
    }
}
