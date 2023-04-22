namespace DoubleLinkedListLibrary
{
    public class DoubleNode
    {
        public DoubleNode()
        {
            Previous = null;
            Next = null;
        }

        public DoubleNode(int value) : this()
        {
            Value = value;
        }

        public int Value { get; set; }

        public DoubleNode Next { get; set; }

        public DoubleNode Previous { get; set; }
    }
}