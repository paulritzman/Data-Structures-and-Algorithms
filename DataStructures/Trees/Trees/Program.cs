using System;
using Trees.Classes;

namespace Trees
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchTree bsTree = new BinarySearchTree(new Node(50));

            for (int i = 1; i < 100; i = i * 3)
            {
                bsTree.Add(bsTree.Root, new Node(i));
            }

            for (int i = 2; i < 100; i = i * 2)
            {
                bsTree.Add(bsTree.Root, new Node(i));
            }

            Console.ReadKey();
            Console.Clear();

            bsTree.Search(bsTree.Root, 8);

            Console.ReadKey();
        }
    }
}
