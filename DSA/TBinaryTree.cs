using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{

    class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    class TBinaryTree
    {
        public Node Root { get; private set; }

        public TBinaryTree()
        {
            Root = null;
        }

        public void Insert(int data)
        {
            Root = InsertRec(Root, data);
        }

        private Node InsertRec(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }

            if (data < root.Data)
            {
                root.Left = InsertRec(root.Left, data);
            }
            else if (data > root.Data)
            {
                root.Right = InsertRec(root.Right, data);
            }

            return root;
        }

        public void InorderTraversal()
        {
            Console.Write("In-order Traversal: ");
            InorderRec(Root);
            Console.WriteLine();
        }

        private void InorderRec(Node root)
        {
            if (root != null)
            {
                InorderRec(root.Left);
                Console.Write(root.Data + " ");
                InorderRec(root.Right);
            }
        }

        public void PreorderTraversal()
        {
            Console.Write("Pre-order Traversal: ");
            PreorderRec(Root);
            Console.WriteLine();
        }

        private void PreorderRec(Node root)
        {
            if (root != null)
            {
                Console.Write(root.Data + " ");
                PreorderRec(root.Left);
                PreorderRec(root.Right);
            }
        }

        public void PostorderTraversal()
        {
            Console.Write("Post-order Traversal: ");
            PostorderRec(Root);
            Console.WriteLine();
        }

        private void PostorderRec(Node root)
        {
            if (root != null)
            {
                PostorderRec(root.Left);
                PostorderRec(root.Right);
                Console.Write(root.Data + " ");
            }
        }
    }
}
