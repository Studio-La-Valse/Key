namespace StudioLaValse.Key
{
    public abstract class PersistentElement : IEquatable<PersistentElement>
    {
        public ElementId ElementId { get; }

        public PersistentElement(IKeyGenerator<int> keyGenerator)
        {
            ElementId = new(keyGenerator);
        }

        public PersistentElement(int elementId)
        {
            ElementId = new(elementId);
        }

        public override string ToString()
        {
            return $"Persistent Element {ElementId}";
        }

        public bool Equals(PersistentElement? other)
        {
            if (other is null)
            {
                return false;
            }

            return ElementId.Equals(other.ElementId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersistentElement);
        }

        public override int GetHashCode()
        {
            return ElementId.GetHashCode();
        }
    }
}
