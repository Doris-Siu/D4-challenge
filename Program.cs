//using D4_challenge;

//static Node CreateExampleTree()
//{
//    Node root = new Node("1",
//        new Node("2", new Node("5", new Node("9"), null, null), null, null),
//        new Node("3", new Node("6", new Node("10"), null, null), new Node("7"), null),
//        new Node("4", new Node("8"), null, null)
//        );

//    return root;
//}


//Node myTree = CreateExampleTree();

//Console.WriteLine("----------------------------");
//Console.WriteLine("Breadth-First Search BFS Algorithm in C#");

//Console.WriteLine("----------------------------");

//BFSTraversal.BFSTransverse(myTree);

//var cts = new CancellationTokenSource();

//var normalQ = new Queue<string>();
//var goldQ = new Queue<string>();
//var platinumQ = new Queue<string>();

//normalQ.Enqueue("Aaron");
//goldQ.Enqueue("Ben");
//platinumQ.Enqueue("Carson");
//goldQ.Enqueue("Dickson");
//platinumQ.Enqueue("Eason");
//normalQ.Enqueue("Fishy");

//while (!cts.IsCancellationRequested)
//{
//    await Task.Delay(1000);

//    if (platinumQ.Count>0)
//    {
//        var platinumItem = platinumQ.Dequeue();
//        Console.WriteLine($"Platinum: {platinumItem}");
//        continue;
//    }

//    if (goldQ.Count > 0)
//    {
//        var goldItem = goldQ.Dequeue();
//        Console.WriteLine($"Gold: {goldItem}");
//        continue;
//    }

//    if (normalQ.Count > 0)
//    {
//        var normalItem = normalQ.Dequeue();
//        Console.WriteLine($"Normal: {normalItem}");
//        continue;
//    }

//}


// Priority queue - only 1 queue for processing

using System.Diagnostics;

var queue = new PriorityQueue<string, (int, long)>();

queue.Enqueue("Aaron", (3, Stopwatch.GetTimestamp())); 
queue.Enqueue("Ben", (2, Stopwatch.GetTimestamp())); 
queue.Enqueue("Carson", (1, Stopwatch.GetTimestamp()));
queue.Enqueue("Dickson", (2, Stopwatch.GetTimestamp()));
queue.Enqueue("Eason", (1, Stopwatch.GetTimestamp()));
queue.Enqueue("Fishy", (3, Stopwatch.GetTimestamp()));

var cts = new CancellationTokenSource();

while (!cts.IsCancellationRequested)
{
    await Task.Delay(1000);

    if (queue.Count>0)
    {
        var item = queue.Dequeue();
        Console.WriteLine($"{item}");
    }
}





