using System;
namespace D4_challenge
{
	public class Node
	{
		public Node left { get; set; }
        public Node middle { get; set; }
		public Node right{ get; set; }
		public string textData { get; set; }

		public Node(string textData, Node left, Node middle, Node right)
		{
			this.textData = textData;
			this.left = left;
			this.middle = middle;
			this.right = right;
		}

		// leaf node
		public Node(string textData)
		{
            this.textData = textData;
            this.left = null;
            this.middle = null;
            this.right = null;

        }

	}
}

