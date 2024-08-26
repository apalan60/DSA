> Suppose that you implement a queue using a null-terminated singly-linked list, maintaining a reference to the item least recently added (the front of the list) but not maintaining a reference to the item most recently added (the end of the list). What are the worst-case running times for enqueue and dequeue?
  如果只儲存LinkedList的First node，enqueue跟dequeue的運行時間會變化為何?

### Enqueue Operation:
- **Action**: Adding a new item to the queue.
- **Details**: In a standard queue, new elements are added to the end (rear) of the list. However, since we only maintain a reference to the front of the list and do not maintain a reference to the end of the list, we must traverse the entire list to find the end before we can insert the new element.

- **Worst-case time complexity**: To find the end of the list (since it’s singly linked), we need to traverse the entire list, which takes \(O(n)\) time (where \(n\) is the number of elements in the queue). Once the end is found, adding the new element takes \(O(1)\) time. Thus, the overall time complexity for enqueue in the worst case is \(O(n)\).

### Dequeue Operation:
- **Action**: Removing an item from the queue.
- **Details**: The dequeue operation removes the front element of the queue, which is the element that the front reference is already pointing to.

- **Worst-case time complexity**: Since you already have a reference to the front of the list, you can remove the front element in \(O(1)\) time. After removing the front element, you need to update the front reference to the next element in the list, which also takes \(O(1)\) time. Therefore, the time complexity for the dequeue operation in the worst case is \(O(1)\).

### Summary of Worst-Case Time Complexities:
- **Enqueue**: \(O(n)\) — because you need to traverse the list to find the end before you can add a new element.
- **Dequeue**: \(O(1)\) — because you can remove the front element directly and update the front reference.
