namespace StudioLaValse.Key
{
    public class ElementId : IEquatable<ElementId>
    {
        public static ElementId InvalidElementId = new (-1);


        public int IntValue { get; }



        public ElementId(int id)
        {
            IntValue = id;
        }

        public ElementId(IKeyGenerator<int> keyGenerator) : this(keyGenerator.Generate())
        {

        }

        public bool IsValid() => IntValue >= 0;

        public override string ToString()
        {
            return $"Element {IntValue}";
        }

        public sealed override bool Equals(object? obj)
        {
            return Equals(obj as ElementId);
        }

        public override int GetHashCode()
        {
            return IntValue.GetHashCode();
        }

        public bool Equals(ElementId? other)
        {
            if (other is null)
            {
                return false;
            }

            return other.IntValue.Equals(IntValue);
        }

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

        public static bool operator !=(ElementId first, ElementId second)
        {
            return !(first == second);
        }
    }
}
