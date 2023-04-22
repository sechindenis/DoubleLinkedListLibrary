namespace DoubleLinkedListLibrary.Test
{
    public class ConstructorTests
    {
        // empty constructor
        [Test]
        public void ConstructorEmptyTest()
        {
            int expected = 0;
            DoubleLinkedList list = new DoubleLinkedList();
            int actual = list.Length;

            Assert.That(actual, Is.EqualTo(expected));
        }

        // constructor by value
        [TestCase(1, 1)]
        [TestCase(1, -1)]
        [TestCase(1, 0)]
        public void ConstructorByValueTest(int expectedLength, int expectedValue)
        {
            DoubleLinkedList list = new DoubleLinkedList(expectedValue);
            int actualLength = list.Length;
            int actualValue = list[0];

            Assert.That(actualLength, Is.EqualTo(expectedLength));
            Assert.That(actualValue, Is.EqualTo(expectedValue));
        }

        // constructor by array
        // positive
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        public void ConstructorByArrayOfValuesPositiveTest(int index, int expectedValue)
        {
            int[] ints = new int[] { 1, 2, 3 };
            DoubleLinkedList list = new DoubleLinkedList(ints);
            int expectedLength = ints.Length;
            int actualLength = list.Length;
            int actualValue = list[index];

            Assert.That(actualValue, Is.EqualTo(expectedValue));
            Assert.That(actualLength, Is.EqualTo(expectedLength));
        }

        // negative
        [Test]
        public void ConstructorByArrayOfValuesNegativeTest()
        {
            int[] ints = null;

            Assert.Throws<NullReferenceException>(() => new DoubleLinkedList (ints));
        }
    }
}