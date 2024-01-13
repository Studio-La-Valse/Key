namespace StudioLaValse.Key
{
    /// <summary>
    /// Creates a new implementation of the <see cref="IKeyGenerator{TKey}"/> that returns incrementing integer values, starting from 0.
    /// </summary>
    public class IncrementalIntGeneratorFactory : IKeyGeneratorFactory<int>
    {
        /// <inheritdoc/>
        public IKeyGenerator<int> CreateKeyGenerator()
        {
            return new IncrementalIntGenerator();
        }
    }
}
