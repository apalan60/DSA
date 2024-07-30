namespace QuickFind_Eager;

/// <summary>
/// 效能: 初始化: n, Union: n  => 若有n個數列，要耗費 n²的時間
/// </summary>
public class QuickFind
{
    private readonly int[] _id;

    public QuickFind(int n)
    {
        _id = new int[n];
        for (int i = 0; i < n; i++)
        {
            _id[i] = i;
        }
    }

    public bool Connected(int p, int q) => _id[p] == _id[q];

    public void Union(int p, int q)
    {
        int pId = _id[p];
        int qId = _id[q];
        for (int i = 0; i < _id.Length; i++)
        {
            if (_id[i] == pId) _id[i] = qId;
        }
    }
}