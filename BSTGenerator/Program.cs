using System;
using System.Diagnostics; //for the stopwatch feature

namespace BSTGenerator
{

    class Node
    {
        public int Data;
        public Node LeftChild;
        public Node RightChild;

        public Node() //default constructor
        {
            Data = 0;
            LeftChild = null;
            RightChild = null;
        }

        public Node(int x)
        {
            Data = x;
        }
    }

    class Tree
    {
        public Node insert(Node root, int v)
        {
            if (root == null)
            {
                root = new Node();
                root.Data = v;
            }
            else if (v < root.Data)
            {
                root.LeftChild = insert(root.LeftChild, v);
            }
            else
            {
                root.RightChild = insert(root.RightChild, v);
            }

            return root;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tree bst = new Tree();
            Node root = null;
            Random random = new Random();


            Console.Write("How many nodes do you want? ");
            int numNodes = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[numNodes];

            for (int i = 0; i < numNodes; i++)
            {
                a[i] = random.Next(100);
            }


            Stopwatch watch = new Stopwatch();
            watch.Start();

            for (int i = 0; i < numNodes; i++)
            {
                bst.insert(root, a[i]);

            }

            watch.Stop();
            TimeSpan ts = watch.Elapsed;
            PrintClock(ts);

            foreach (int items in a)
            {
                Console.WriteLine(items);
            }

        }

        // Format and display the TimeSpan value
        static void PrintClock(TimeSpan time)
        {
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                time.Hours, time.Minutes, time.Seconds,
                time.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

        }
    }
}
