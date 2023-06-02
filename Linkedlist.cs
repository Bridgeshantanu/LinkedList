using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    internal class Linkedlist<T>
    {
        public Node<T> head;
        public Node<T> tail;

        public void AddNode(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }
        public void Append(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
        }
        public void Insert(T value1, T value2, T newValue)
        {
            Node<T> newNode = new Node<T>(newValue);

            Node<T> current = head;
            while (current != null)
            {
                if (current.data.Equals(value1) && current.next != null && current.next.data.Equals(value2))
                {
                    newNode.next = current.next;
                    current.next = newNode;
                    break;
                }
                current = current.next;
            }
        }
        public void Pop()
        {
            if (head != null)
            {
                head = head.next;
            }
        }
        public void PrintList()
        {
            Node<T> current = head;

            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }

    }
}
