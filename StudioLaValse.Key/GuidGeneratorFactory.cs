namespace StudioLaValse.Key
{
    /// <summary>
    /// Guid implementation for the key generator factory
    /// </summary>
    public class GuidGeneratorFactory : IKeyGeneratorFactory<Guid>
    {
        /// <inheritdoc/>
        public IKeyGenerator<Guid> CreateKeyGenerator()
        {
            return new GuidGenerator();
        }
    }
}
