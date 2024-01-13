namespace StudioLaValse.Key
{
    /// <summary>
    /// Creates an implementation of the <see cref="IKeyGenerator{TKey}"/> that generates random integer values, from 0.
    /// </summary>
    public class RandomIntGeneratorFactory : IKeyGeneratorFactory<int>
    {
        /// <inheritdoc/>
        public IKeyGenerator<int> CreateKeyGenerator()
        {
            return new RandomIntGenerator();
        }
    }
}
