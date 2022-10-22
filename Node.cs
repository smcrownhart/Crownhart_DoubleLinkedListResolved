namespace Crownhart_DoubleLinkedListResolved
{
    internal class Node
    {
        private string _data;
        public Node Next;
        public Node Previous;

        public Node(string Name)
        {
            _data = Name;
        }
        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }

    }
}