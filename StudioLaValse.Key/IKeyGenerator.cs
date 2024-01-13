namespace StudioLaValse.Key
{
    public interface IKeyGenerator<TKey> where TKey : IEquatable<TKey>
    {
        TKey Generate();
    }
}