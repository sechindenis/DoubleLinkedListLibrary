namespace DoubleLinkedListLibrary.Test
{
    public class DownSortTests
    {
        // down sort bubble
        // list length >= 2
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        [TestCase(5, 5)]
        public void DownSortBubbleSeveralElementsListTest(int mockParametr, int mockExpected)
        {
            DoubleLinkedList actual = new DoubleLinkedList(DownSortMock.GetMockParametrForDownSort(mockParametr));
            actual.DownSortBubble();
            DoubleLinkedList expected = new DoubleLinkedList(DownSortMock.GetMockExpectedForDownSort(mockExpected));

            Assert.That(actual, Is.EqualTo(expected));
        }

        // list length = 1
        [TestCase(1)]
        [TestCase(0)]
        [TestCase(-1)]
        public void DownSortBubbleOneElementListTest(int value)
        {
            DoubleLinkedList actual = new DoubleLinkedList(value);
            actual.DownSortBubble();
            DoubleLinkedList expected = new DoubleLinkedList(value);

            Assert.That(actual, Is.EqualTo(expected));
        }

        // empty list
        [Test]
        public void DownSortBubbleEmptyListTest()
        {
            DoubleLinkedList actual = new DoubleLinkedList();
            actual.DownSortBubble();
            DoubleLinkedList expected = new DoubleLinkedList();

            Assert.That(actual, Is.EqualTo(expected));
        }

        // down sort insertions
        // list length >= 2
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        [TestCase(5, 5)]
        public void DownSortInsertionsSeveralElementsListTest(int mockParametr, int mockExpected)
        {
            DoubleLinkedList actual = new DoubleLinkedList(DownSortMock.GetMockParametrForDownSort(mockParametr));
            actual.DownSortInsertions();
            DoubleLinkedList expected = new DoubleLinkedList(DownSortMock.GetMockExpectedForDownSort(mockExpected));

            Assert.That(actual, Is.EqualTo(expected));
        }

        // list length = 1
        [TestCase(1)]
        [TestCase(0)]
        [TestCase(-1)]
        public void DownSortInsertionsOneElementListTest(int value)
        {
            DoubleLinkedList actual = new DoubleLinkedList(value);
            actual.DownSortInsertions();
            DoubleLinkedList expected = new DoubleLinkedList(value);

            Assert.That(actual, Is.EqualTo(expected));
        }

        // empty list
        [Test]
        public void DownSortInsertionsEmptyListTest()
        {
            DoubleLinkedList actual = new DoubleLinkedList();
            actual.DownSortInsertions();
            DoubleLinkedList expected = new DoubleLinkedList();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    public static class DownSortMock
    {
        public static int[] GetMockParametrForDownSort(int number)
        {
            int[] parametr = new int[0];

            switch (number)
            {
                case 1:
                    parametr = new int[] { 1, 2, 3, 4, 5 };
                    break;

                case 2:
                    parametr = new int[] { 10, 100, 1000, 10000 };
                    break;

                case 3:
                    parametr = new int[] { -2, -1, 5 };
                    break;

                case 4:
                    parametr = new int[] { 1, 1, 1 };
                    break;

                case 5:
                    parametr = new int[] { -3, -2, -1 };
                    break;
            }

            return parametr;
        }

        public static int[] GetMockExpectedForDownSort(int number)
        {
            int[] parametr = new int[0];

            switch (number)
            {
                case 1:
                    parametr = new int[] { 5, 4, 3, 2, 1 };
                    break;

                case 2:
                    parametr = new int[] { 10000, 1000, 100, 10 };
                    break;

                case 3:
                    parametr = new int[] { 5, -1, -2 };
                    break;

                case 4:
                    parametr = new int[] { 1, 1, 1 };
                    break;

                case 5:
                    parametr = new int[] { -1, -2, -3 };
                    break;
            }

            return parametr;
        }
    }
}