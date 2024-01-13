namespace StudioLaValse.Key
{
    public interface IKeyGeneratorFactory<T> where T: IEquatable<T>
    {
        IKeyGenerator<T> CreateKeyGenerator();
    }
}
