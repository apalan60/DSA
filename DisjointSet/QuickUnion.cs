namespace DisjointSet;

/// <summary>
/// Tree can get tall
/// </summary>
public class QuickUnion
{
    private readonly int[] _id;
    
    public QuickUnion(int n)  //O(n)
    {
        _id = new int[n];
        for (int i = 0; i < n; i++)
        {
            _id[i] = i;
        }
    }

    public bool Connected(int p, int q) => Root(p) == Root(q);  //O(n) in worst situation
    
    public void Union(int p , int q)  //O(n) in worst situation
    {
        int rootP = Root(p);
        int rootQ = Root(q);

        _id[rootP] = rootQ;
    }
    
    private int Root(int i)
    {
        while (_id[i] != i)
        {
            i = _id[i];
        }

        return i;
    }

}