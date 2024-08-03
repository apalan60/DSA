// Given a sorted array and a key, find index of the key in the array

int BinarySearch(int[] a, int key)
{
    int lo = 0;
    int hi = a.Length - 1;

    while (lo <= hi)
    {
        //int mid = (hi + lo) / 2;  
        int mid = lo + (hi - lo) / 2;  //數學上與上述等價，但此方法較不會在a + b時就出現溢位問題 https://stackoverflow.com/questions/25571359/why-we-write-lohi-lo-2-in-binary-search  
        if (key < a[mid])
            hi = mid - 1;
        else if (key > a[mid])
            lo = mid + 1;
        else
            return mid;
    }
        

    return -1;
}

int[] sortedArray = [1, 5, 8, 12, 17, 30];


int key = 1;
Console.WriteLine(BinarySearch(sortedArray, key)); //0

key = 8;
Console.WriteLine(BinarySearch(sortedArray, key)); //2

key = 7;
Console.WriteLine(BinarySearch(sortedArray, key)); //-1

key = 17;
Console.WriteLine(BinarySearch(sortedArray, key)); //4