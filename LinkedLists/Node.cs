namespace LinkedLists
{
    class Node
    {
        public string Value { get; }
        public Node Next { get; set; }

        public Node(string value, Node next)
        {
            Value = value;
            Next = next;
        }
    }
}
