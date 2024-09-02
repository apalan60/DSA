namespace Stack;

public class LinkedListStackOfObjects<TItem>
{
    private Node? _first;
    
    private class Node
    {
        internal TItem Item = default!;
        internal Node? Next;
    }
    
    private bool IsEmpty() => _first is null;

    public void Push(TItem item)
    {
        var oldFirst = _first;
        _first = new Node
        {
            Item = item,
            Next = oldFirst
        };
    }

    public TItem? Pop()
    {
        TItem? item = default(TItem);
        
        if (IsEmpty()) 
            return item;
        
        item = _first!.Item;
        _first = _first.Next;

        return item;
    }
}