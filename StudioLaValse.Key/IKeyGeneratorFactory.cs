namespace StudioLaValse.Key
{
    /// <summary>
    /// The generic key generator factory
    /// </summary>
    /// <typeparam name="T">The type of key</typeparam>
    public interface IKeyGeneratorFactory<T> where T: IEquatable<T>
    {
        /// <summary>
        /// Create a new keygenerator.
        /// </summary>
        /// <returns></returns>
        IKeyGenerator<T> CreateKeyGenerator();
    }
}
