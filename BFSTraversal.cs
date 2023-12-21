using System;
using System.Xml.Linq;

namespace D4_challenge
{
	public class BFSTraversal
	{

		public static void BFSTransverse(Node node)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Count >0)
            {
                node = queue.Dequeue();
                Console.WriteLine(node.textData);

                if (node.left !=null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.middle != null)
                {
                    queue.Enqueue(node.middle);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            
        }

    }
}
