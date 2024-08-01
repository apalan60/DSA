namespace DisjointSetUnion;

public class PathCompression
{
    private readonly int[] _parent;
    private readonly int[] _size;

    public PathCompression(int n)
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
            _parent[i] = _parent[_parent[i]]; //除了查找，多了這行來處理路徑壓縮，讓自己最後指向根結點，並且路徑上的點也都指向根結點  
            i = _parent[i];
        }

        return i;
    }

    public bool Connected(int p, int q) => Root(p) == Root(q);

    public void Union(int p , int q)
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