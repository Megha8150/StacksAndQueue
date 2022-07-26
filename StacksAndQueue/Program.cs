// See https://aka.ms/new-console-template for more information
using StacksAndQueue;

Stack stack = new Stack();
stack.push(70);
stack.push(30);
stack.push(56);
stack.print();

while (!stack.isEmpty())
{
    Console.WriteLine();
    stack.peek();
    stack.pop();
    stack.print();
    Console.WriteLine();
}
    Console.WriteLine("Queue");

    Queue queue = new Queue();
queue.Enqueue(56);
queue.Enqueue(30);
queue.Enqueue(70);
queue.print();

while (!queue.isEmpty())
{
    Console.WriteLine();
    queue.peek();
    queue.pop();
    queue.print();
    Console.WriteLine();
}