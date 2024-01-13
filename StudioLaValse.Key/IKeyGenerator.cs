namespace StudioLaValse.Key
{
    /// <summary>
    /// Generic key generator interface.
    /// </summary>
    /// <typeparam name="TKey">The type of key</typeparam>
    public interface IKeyGenerator<TKey> where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// Generate the new key.
        /// </summary>
        /// <returns></returns>
        TKey Generate();
    }
}