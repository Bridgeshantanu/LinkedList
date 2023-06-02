namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Linkedlist<int> linkedList = new Linkedlist<int>();
            linkedList.AddNode(70);
            linkedList.AddNode(30);
            linkedList.AddNode(56);
            linkedList.PrintList();

        }
    }
}