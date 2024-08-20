namespace Stack;

public class FixedCapacityStackOfStrings
{
    private readonly string[] _stacks;
    private int _n = 0;
    
    public FixedCapacityStackOfStrings(int capacity)
    {
        _stacks = new string[capacity];
    }

    public void Push(string s) => _stacks[_n++] = s;

    public string Pop() => _stacks[--_n];
}