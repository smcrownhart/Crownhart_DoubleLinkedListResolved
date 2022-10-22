using Crownhart_DoubleLinkedListResolved;


Node Head = null;
Node Tail = null;

AddNode(ref Head, ref Tail, "Dan");
AddNode(ref Head, ref Tail, "Raylene");
AddNode(ref Head, ref Tail, "Micah");
AddNode(ref Head, ref Tail, "Susan");

PrintForward(Head);
PrintBackward(Tail);

static void PrintForward(Node Head)
{
    Node Current = Head;

    while (Current != null)
    {
        Console.WriteLine(Current.Data);
        Current = Current.Next;
    }
}
static void PrintBackward(Node Tail)
{
    Node Current = Tail;

    Console.WriteLine();
    Console.WriteLine("In Reverse");
    Console.WriteLine();
    while (Current != null)
    {
        Console.WriteLine(Current.Data);
        Current = Current.Previous;
    }


}
static void AddNode(ref Node Head, ref Node Tail, string Name2Add)
{
    if (Head == null)
    {
        Head = new Node(Name2Add);
        //return Head;
    }
    Node current = Head;

    while (current.Next != null)
    {
        current = current.Next;
    }

    //https://www.youtube.com/watch?v=l9gPJeJ-GkA
    Node temp = Tail;//create a temp node that is empty as a place holder for previous data
    current.Next = new Node(Name2Add);
    Tail = current.Next;
    Tail.Previous = temp;//use the place holder to put previous data in



}
//current = Tail.Previous;

//return Tail;
//current.Previous = Head; this returns the top name
//Tail = current.Previous; this sets current to null
// current.Previous = current.Next; this does nothing
//current.Next = current.Previous; does nothing