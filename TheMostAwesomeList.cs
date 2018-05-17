using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class GoogleList
    {
        public Node Head { set; get; }
        public Node Tail { set; get; }
        public int Count { set; get; }

        public void Add(string userInput)
        {
            Node node = new Node { Next = null, Data = userInput };
            if (Count == 0)
            {
                Head = node;
                Tail = node;
                Count++;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
                Count++;
            }
        }
        public Node GetNode(int index) // get
        {
            int counter = 0;
            Node node = Head;
            while (counter != index)
            {
                node = node.Next;
                counter++;
            }
            return node;
        }
        public void RemoveAll(string userInput) // remove the reference to the node to remove it. remove the .next
        {
            Node node = Head;
            while (node.Data == userInput)
            {
                Head = Head.Next;
                node = node.Next;
                Count--;
            }
            while (node != null)
            {
                while (node.Next != null && node.Next.Data == userInput)
                {
                    node.Next = node.Next.Next;
                    Count--;
                }
                node = node.Next;
            }
        }
        public void Clear()
        {
            Count = 0;
        }
        public void PrintInfo()
        {
            Node node = Head;
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }
    }
}