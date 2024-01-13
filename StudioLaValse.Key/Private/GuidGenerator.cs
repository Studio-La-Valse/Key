namespace StudioLaValse.Key
{
    internal class GuidGenerator : IKeyGenerator<Guid>
    {
        public GuidGenerator()
        {
            
        }

        public Guid Generate()
        {
            return Guid.NewGuid();
        }
    }
}
