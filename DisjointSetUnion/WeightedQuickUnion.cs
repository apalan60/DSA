namespace DisjointSetUnion;

/// <summary>
/// 解決Quick Union樹過高導致Find Root過慢的問題
/// Solution: 讓小樹作為大樹的根，樹才不會長高
/// 樹唯一可能長高的時間點就是兩顆等高的樹合併時，所以一旦樹長高，必然是兩倍
/// Find的時間複雜度轉為 O(log(n))
/// 實作上有以下幾種方案
/// 1. Union by Size
/// 2. Union by Height
/// 3. Union by Rank
/// 其他合理的替代方案 Union by height / rank
/// </summary>
public class WeightedQuickUnion
{
    private readonly int[] _parent;
    private readonly int[] _size;

    public WeightedQuickUnion(int n)
    {
        _parent = new int[n];
        _size = new int[n];
        for (int i = 0; i < n; i++)
        {
            _parent[i] = i;
            _size[i] = 1;
        }
    }

    private int Root(int i)
    {
        while (_parent[i] != i)
        {
            i = _parent[i];
        }

        return i;
    }

    public bool Connected(int p, int q) => Root(p) == Root(q);

    public void Union(int p, int q)
    {
        int rootP = Root(p);
        int rootQ = Root(q);

        if (rootP == rootQ)
        {
            return;
        }

        if (_size[rootP] < _size[rootQ])
        {
            _parent[rootP] = rootQ;
            _size[rootQ] += _size[rootP];
        }
        else
        {
            _parent[rootQ] = rootP;
            _size[rootP] += _size[rootQ];
        }
    }
}