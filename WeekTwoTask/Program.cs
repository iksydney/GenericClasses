
var list = new WeekTwoTask.SinglyLinkedList<int>();

list.Add(3);
list.Add(2);
list.Add(4);
list.Add(5);
var count = list.Add(5);
Console.WriteLine(count);
list.Display();