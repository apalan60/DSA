﻿using Stack;

var fixedStack = new FixedCapacityStackOfStrings(10);
fixedStack.Push("one");
fixedStack.Push("two");
fixedStack.Push("three");
for (int i = 0; i < 3; i++) 
{
    Console.WriteLine(fixedStack.Pop());
}


var linkListStackOfStrings = new LinkListStackOfStrings();
Console.WriteLine(linkListStackOfStrings.IsEmpty? "empty" : "not empty");
linkListStackOfStrings.Push("one");
linkListStackOfStrings.Push("two");
linkListStackOfStrings.Push("three");

Console.WriteLine(linkListStackOfStrings.Pop());
Console.WriteLine(linkListStackOfStrings.Pop());
Console.WriteLine(linkListStackOfStrings.Pop());