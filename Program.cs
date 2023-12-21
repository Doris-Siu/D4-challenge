using D4_challenge;

static Node CreateExampleTree()
{
    Node root = new Node("1",
        new Node("2", new Node("5", new Node("9"), null, null), null, null),
        new Node("3", new Node("6", new Node("10"), null, null), new Node("7"), null),
        new Node("4", new Node("8"), null, null)
        );

    return root;
}


Node myTree = CreateExampleTree();

Console.WriteLine("----------------------------");
Console.WriteLine("Breadth-First Search BFS Algorithm in C#");
Console.WriteLine("----------------------------");

BFSTraversal.BFSTransverse(myTree);



