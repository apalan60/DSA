using Queue;

var queue = new LinkedListQueueOfString();
queue.Enqueue("A");
queue.Enqueue("B");
queue.Enqueue("C");
queue.Enqueue("D");
queue.Enqueue("E");


Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());