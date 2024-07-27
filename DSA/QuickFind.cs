namespace DSA;

public class QuickFind
{
    private int[] _id;

    public void Union(int p , int q)
    {
        int pId = _id[p];
        int qId = _id[q];

        for (int i = 0; i < _id.Length; i++)
        {
            if (_id[i] == pId)
            {
                _id[i] = qId;
            }
        }
    }
}