using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITFDN120_Assignment5
{
    class Node
    {
        private Node next;
        private int value;

        public int Value { get => value; set => this.value = value; }
        internal Node Next { get => next; set => next = value; }
    }

    class LinkedList
    {
        private Node head;
        //Don't want 
        public Node Head { get => head; }

        public void Append(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;

            if(head == null)
            {
                head = newNode;
            }
            else
            {
                Node node = head;
                while(node.Next != null)
                {
                    node = node.Next;
                }
                node.Next = newNode;
            }
        }

        public void Reverse()
        {
            Node prev = null;
            Node current = head;
            Node next;

            //Iterate while reversing links
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        public void Print()
        {
            Node node = head;
            while (node.Next != null)
            {
                Console.Write(node.Value + ", ");
                node = node.Next;
            }
            Console.Write(node.Value);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] listSource = { 1, 2, 3, 4, 5 };

            LinkedList List1 = new LinkedList();
            //Fill the first list
            for(int i = 0; i<listSource.Length; i++)
            {
                List1.Append(listSource[i]);
            }
            Console.WriteLine("Linked List Contents:");
            List1.Print();
            List1.Reverse();         
            Console.WriteLine("Linked List Contents:");
            List1.Print();

            Console.ReadLine();
        }
    }
}
