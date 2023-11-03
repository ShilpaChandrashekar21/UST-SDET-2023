/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{

    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    class BinaryTreeExample<T> where T : IComparable<T>
    {
        private Node<T> root;

        public BinaryTreeExample()
        {
            root = null;
        }

        public void Insert(T data)
        {
            root = InsertNode(root, data);
            Console.WriteLine($"Inserted: {data}");
        }

        private Node<T> InsertNode(Node<T> node, T data)
        {
            if (node == null)
            {
                return new Node<T>(data);
            }

            if (data.CompareTo(node.Data) < 0)
            {
                node.Left = InsertNode(node.Left, data);
            }
            else if (data.CompareTo(node.Data) > 0)
            {
                node.Right = InsertNode(node.Right, data);
            }

            return node;
        }

        public void InorderTraversal()
        {
            Console.Write("Inorder Traversal: ");
            Inorder(root);
            Console.WriteLine();
        }

        private void Inorder(Node<T> node)
        {
            if (node != null)
            {
                Inorder(node.Left);
                Console.Write(node.Data + " ");
                Inorder(node.Right);
            }
        }

        public bool Search(T data)
        {
            return SearchNode(root, data);
        }

        private bool SearchNode(Node<T> node, T data)
        {
            if (node == null)
            {
                return false;
            }

            if (data.CompareTo(node.Data) == 0)
            {
                return true;
            }

            if (data.CompareTo(node.Data) < 0)
            {
                return SearchNode(node.Left, data);
            }

            return SearchNode(node.Right, data);
        }
    }
}
*/