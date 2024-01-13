namespace StudioLaValse.Key
{
    /// <summary>
    /// Represents an immuntal element id.
    /// </summary>
    public class ElementId : IEquatable<ElementId>
    {
        /// <summary>
        /// The invalid element id.
        /// </summary>
        public static readonly ElementId InvalidElementId = new(new IntGenerator(-1));

        /// <summary>
        /// The intvalue.
        /// </summary>
        public int IntValue { get; }


        /// <summary>
        /// Construct an element id by generating a new key.
        /// </summary>
        /// <param name="keyGenerator"></param>
        public ElementId(IKeyGenerator<int> keyGenerator)
        {
            IntValue = keyGenerator.Generate();
        }

        /// <summary>
        /// Determines if the element id is valid.
        /// </summary>
        /// <returns></returns>
        public bool IsValid() => IntValue >= 0;

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Element {IntValue}";
        }

        /// <inheritdoc/>
        public sealed override bool Equals(object? obj)
        {
            return Equals(obj as ElementId);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return IntValue.GetHashCode();
        }

        /// <inheritdoc/>
        public bool Equals(ElementId? other)
        {
            if (other is null)
            {
                return false;
            }

            return other.IntValue.Equals(IntValue);
        }

        /// <summary>
        /// Equality comparer for two element id's.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static bool operator ==(ElementId first, ElementId second)
        {
            if (first is null && second is null)
            {
                return true;
            }

            if (first is null || second is null)
            {
                return false;
            }

            return first.IntValue == second.IntValue;
        }

        /// <summary>
        /// Inequality comparer for two element ids.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static bool operator !=(ElementId first, ElementId second)
        {
            return !(first == second);
        }
    }
}
