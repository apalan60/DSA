using QuickFind_Eager;

//有一組數列int[]
//index為編號, 可以Union使兩個點的value相等
//value相等代表該編號的點相連
//實作連結點，以及判斷點是否相連的方法



QuickFind quickFind = new QuickFind(10);

Console.WriteLine(quickFind.Connected(1,2));
Console.WriteLine(quickFind.Connected(1,3));
Console.WriteLine(quickFind.Connected(1,4));


Console.WriteLine("---------Union----------");
quickFind.Union(1, 2);
quickFind.Union(2, 3);
Console.WriteLine(quickFind.Connected(1,3));
Console.WriteLine(quickFind.Connected(1,4));