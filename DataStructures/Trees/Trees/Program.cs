using System;
using Trees.Classes;

namespace Trees
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree binTree = new BinaryTree(new Node(1));

            for (int i = 2; i < 10; i++)
            {
                binTree.Add(binTree.Root, new Node(i));
            }

            Node foundNode = binTree.Search(binTree.Root, 51);

            if (foundNode != null)
            {
                Console.WriteLine(foundNode.Value);
            }
            else
            {
                Console.WriteLine("That Node doesn't exist in the Binary Tree.");
            }
            
            Console.ReadKey();
        }
    }
}
