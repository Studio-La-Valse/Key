namespace StudioLaValse.Key
{
    /// <summary>
    /// Represents an immutable persistent element, equatable by element id.
    /// </summary>
    public abstract class PersistentElement : IEquatable<PersistentElement>
    {
        /// <summary>
        /// The element id.
        /// </summary>
        public ElementId ElementId { get; }

        /// <summary>
        /// Construct a new persistent element by providing a key generator.
        /// </summary>
        /// <param name="keyGenerator"></param>
        public PersistentElement(IKeyGenerator<int> keyGenerator)
        {
            ElementId = new(keyGenerator);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Persistent Element {ElementId}";
        }

        /// <inheritdoc/>
        public bool Equals(PersistentElement? other)
        {
            if (other is null)
            {
                return false;
            }

            return ElementId.Equals(other.ElementId);
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as PersistentElement);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return ElementId.GetHashCode();
        }
    }
}
