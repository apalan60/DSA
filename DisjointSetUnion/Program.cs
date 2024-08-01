using DisjointSetUnion;

//有一組數列int[]
//index為編號, 可以Union使兩個點的value相等
//value相等代表該編號的點相連
//實作連結點，以及判斷點是否相連的方法



Console.WriteLine("---------Quick Find----------");
QuickFind quickFind = new QuickFind(10);

Console.WriteLine(quickFind.Connected(1,2));
Console.WriteLine(quickFind.Connected(1,3));
Console.WriteLine(quickFind.Connected(1,4));


quickFind.Union(1, 2);
quickFind.Union(2, 3);
Console.WriteLine(quickFind.Connected(1,3));
Console.WriteLine(quickFind.Connected(1,4));




Console.WriteLine("---------Quick Union----------");
QuickUnion qu = new QuickUnion(10);

Console.WriteLine(qu.Connected(1,2));
Console.WriteLine(qu.Connected(1,3));
Console.WriteLine(qu.Connected(1,4));

qu.Union(1, 2);
qu.Union(2, 3);
qu.Union(6, 1);

Console.WriteLine(qu.Connected(1,3));
Console.WriteLine(qu.Connected(1,4));
Console.WriteLine(qu.Connected(6,3));


Console.WriteLine("---------Weighted Quick Union----------");
WeightedQuickUnion wqu = new WeightedQuickUnion(10);

Console.WriteLine(wqu.Connected(1, 2));
Console.WriteLine(wqu.Connected(1, 3));
Console.WriteLine(wqu.Connected(1, 4));

wqu.Union(1, 2);
wqu.Union(2, 3);
wqu.Union(6, 1);

Console.WriteLine(wqu.Connected(1, 3));
Console.WriteLine(wqu.Connected(1, 4));
Console.WriteLine(wqu.Connected(6, 3));

Console.WriteLine("---------Weighted Quick Union + Path Compression----------");
PathCompression pc = new PathCompression(7);

pc.Union(1, 2);
pc.Union(3, 4);
pc.Union(2, 3);
pc.Union(5, 6);
pc.Union(4, 5);

pc.Connected(1, 6);
pc.Connected(2, 3);
