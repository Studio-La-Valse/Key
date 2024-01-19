namespace StudioLaValse.Key.Tests
{
    internal class PredictableKeyGenerator : IKeyGenerator<int>
    {
        private readonly int number;

        public PredictableKeyGenerator(int number)
        {
            this.number = number;
        }

        public int Generate()
        {
            return number;
        }
    }

    internal class _PersistentElement : PersistentElement
    {
        public _PersistentElement(IKeyGenerator<int> keyGenerator) : base(keyGenerator)
        {
            
        }
    }

    [TestClass]
    public class PersistentElementTests
    {
        [TestMethod]
        public void TestEquality()
        {
            var keyGenerator = new PredictableKeyGenerator(5);
            var first = new _PersistentElement(keyGenerator);
            var second = new _PersistentElement(keyGenerator);

            Assert.IsTrue(first == second);
            Assert.IsTrue(first.Equals(second));
            Assert.AreEqual(first, second);
        }
    }
}