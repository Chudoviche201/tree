using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }

    class Tree
    {
        public Node root;

        public Tree()
        {
            root = null;
        }

        public void Add(int data)
        {
            root = AddRec(root, data);
        }

        private Node AddRec(Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);
            }
            else if (data < node.data)
            {
                node.left = AddRec(node.left, data);
            }
            else if (data > node.data)
            {
                node.right = AddRec(node.right, data);
            }
            return node;
        }

        public void Traverse()
        {
            TraverseRec(root);
        }

        private void TraverseRec(Node node)
        {
            if (node != null)
            {
                TraverseRec(node.left);
                Console.WriteLine(node.data);
                TraverseRec(node.right);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(9);

            tree.Traverse();

            Console.ReadLine();
        }
    }
}
