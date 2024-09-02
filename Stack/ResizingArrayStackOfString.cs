using System.Collections;

namespace Stack;

/// <summary>
/// 在FixedCapacityStackOfStrings版本，無法解決使用者不知道陣列該有幾個元素的問題
/// Solution
/// 在push時，如果陣列滿了，就自動複製並建立兩倍容量的陣列(Repeated doubling)
/// 這個行為的時間複雜度並不到n²，而是3N，因為只有在滿了才翻倍
/// 但pop並不會是容量空閒達1/2時就resize一半
/// 原因在攤還分析（amortized analysis）的結果，假設我們總是將陣列大小縮減至一半，那麼由於每次縮減後我們有 1/2 的閒置空間，我們有可能在後續的操作中很快又需要擴容
/// 導致更多的 resize 操作，進而增加了攤還成本。
/// 透過在 1/4 閾值時縮減容量，減少了頻繁 resize 的可能性，從而降低了 resize 操作的攤還成本
/// </summary>
public class ResizingArrayStackOfString : IEnumerable<string?>
{
    private string?[] _stack;
    private int _index;
    
    public ResizingArrayStackOfString()
    {
        _stack = new string[1];
    }

    public void Push(string item)
    {
        if (_stack.Length == _index)
        {
            Resize(_index * 2);
        }
        _stack[_index++] = item;
    }

    public string? Pop()
    {
        string? item = _stack[--_index];
        _stack[_index] = null;
        if (_index > 0 && _index == _stack.Length / 4) 
            Resize(_stack.Length / 2);
        return item;
    }


    /// <summary>
    /// 複製並建立n倍容量的陣列
    /// </summary>
    /// <param name="capacity"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void Resize(int capacity)
    {
        string?[] copy = new string?[capacity];
        for (int i = 0; i < _index; i++)
        {
            copy[i] = _stack[i];
        }
        _stack = copy;
    }

    public IEnumerator<string?> GetEnumerator()
    {
        var oldIndex = _index;
        while (_index > 0)
            yield return _stack[--_index];
        _index = oldIndex;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}