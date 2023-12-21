using System;
namespace D4_challenge
{
	public class StackQueue
	{
		public static void BasicOperation()
		{
            Stack<string> stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Console.WriteLine(queue.Peek());
            queue.Dequeue();
            Console.WriteLine(queue.Peek());

        }
    }
}

