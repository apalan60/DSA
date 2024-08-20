namespace Stack;

public class FixedCapacityStackOfStrings
{
    private readonly string?[] _stacks;
    private int _n;
    
    public FixedCapacityStackOfStrings(int capacity)
    {
        _stacks = new string[capacity];
    }

    public void Push(string s) => _stacks[_n++] = s;

    public string? Pop()
    {
        var item = _stacks[--_n];
        _stacks[_n] = null;
        return item;
    }
}