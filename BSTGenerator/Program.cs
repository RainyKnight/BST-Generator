using System;
using System.Diagnostics; //for the stopwatch feature

namespace BSTGenerator
{

    class Node
    {
        public int Data { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

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
        public Node root { get; set; }

        public void add(int value)
        {
            Node before = null;
            Node after = this.root;

            while (after != null)
            {
                before = after;
                if(value < after.Data)
                    if (value < after.Data) //Is new node in left tree? 
                        after = after.LeftChild;
                    else if (value > after.Data)//Is new node in right tree?
                        after = after.RightChild;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tree bst = new Tree();

            Console.Write("How many nodes do you want? ");
            int numNodes = Convert.ToInt32(Console.ReadLine());

            Stopwatch watch = new Stopwatch();
            watch.Start();

            //TODO BST generating function

            watch.Stop();
            TimeSpan ts = watch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}
