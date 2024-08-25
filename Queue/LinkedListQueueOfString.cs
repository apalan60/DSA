namespace Queue;

/// <summary>
/// First in first out 
/// </summary>
public class LinkedListQueueOfString
{
    private Node? _first;
    
    private Node? _last;
    
    private class Node
    {
        internal string Item = null!;
        internal Node? Next;
    }

    private bool IsEmpty() => _first == null;
    
    public void Enqueue(string item)
    {
        var oldLast = _last;
        var last = new Node
        {
            Item = item,
            Next = null
        };
        
        if (IsEmpty())
        {
            _first = last;
            _last = last;
        }

        else if (oldLast != null)
        {
            oldLast.Next = last;
            _last = last;
        }

    }

    public string? Dequeue()
    { 
        // Save item to return
        string? first = _first?.Item;
        
        //Delete first node
        _first = _first?.Next;
        
        //Check
        if (IsEmpty()) 
            _last = null;
        
        return first;
    }
}