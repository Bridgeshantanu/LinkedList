﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    internal class SortedLinkedlist<T> where T : IComparable
    {
        public Node<T> head;
        public Node<T> tail;

        public void AddNode(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (head == null || value.CompareTo(head.data) <= 0)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.next != null && value.CompareTo(current.next.data) > 0)
                {
                    current = current.next;
                }

                newNode.next = current.next;
                current.next = newNode;
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
            else if (value.CompareTo(head.data) <= 0)
            {
                newNode.next = head;
                head = newNode;
            }
            else if (value.CompareTo(tail.data) >= 0)
            {
                tail.next = newNode;
                tail = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.next != null && value.CompareTo(current.next.data) >= 0)
                {
                    current = current.next;
                }

                newNode.next = current.next;
                current.next = newNode;
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
        public void PopLast()
        {
            if (head == null)
            {
                return;
            }

            if (head == tail)
            {
                head = null;
                tail = null;
                return;
            }

            Node<T> current = head;
            Node<T> previous = null;
            while (current.next != null)
            {
                previous = current;
                current = current.next;
            }

            previous.next = null;
            tail = previous;
        }
        public bool Search(T value)
        {
            Node<T> current = head;

            while (current != null)
            {
                if (current.data.Equals(value))
                {
                    return true;
                }
                current = current.next;
            }

            return false;
        }
        public void InsertAfter(T valueToFind, T valueToInsert)
        {
            Node<T> newNode = new Node<T>(valueToInsert);

            Node<T> current = head;
            while (current != null)
            {
                if (current.data.Equals(valueToFind))
                {
                    newNode.next = current.next;
                    current.next = newNode;
                    if (current == tail)
                    {
                        tail = newNode;
                    }
                    break;
                }
                current = current.next;
            }
        }
        public void Delete(T value)
        {
            if (head == null)
            {
                return;
            }

            if (head.data.Equals(value))
            {
                head = head.next;
                return;
            }

            Node<T> current = head;
            Node<T> previous = null;
            while (current != null)
            {
                if (current.data.Equals(value))
                {
                    previous.next = current.next;
                    return;
                }
                previous = current;
                current = current.next;
            }
        }

        public int Size()
        {
            Node<T> current = head;
            int size = 0;
            while (current != null)
            {
                size++;
                current = current.next;
            }
            return size;
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
