namespace Stack;

//LinkList Implementation
/// <summary>
/// Stack的資訊巢套在_first，Pop會真的移除最上層的item
/// </summary>
public class LinkListStackOfStrings
{
    private Node? _first;
    private class Node
    {
        internal string? Item;
        
        /// <summary>
        /// Item的下面一層
        /// </summary>
        internal Node? Next;
    }
    
    public bool IsEmpty => _first == null;

    public void Push(string item)
    {
        Node? oldFirst = _first;
        _first = new Node
        {
            Item = item,
            Next = oldFirst
        };
    }

    public string? Pop()
    {
        string? item = _first?.Item;
        _first = _first?.Next;
        return item;
    }
}