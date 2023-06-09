﻿using System.Collections.Generic;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedlist<int> linkedList = new SortedLinkedlist<int>();
            //linkedList.AddNode(70);
            //linkedList.AddNode(30);
            //linkedList.AddNode(56);
            //linkedList.PrintList();

            //linkedList.Append(56);
            //linkedList.Append(30);
            //linkedList.Append(70);
            //linkedList.PrintList();

            //linkedList.AddNode(70);
            //linkedList.AddNode(56);
            //linkedList.Insert(56, 70, 30);
            //linkedList.PrintList();

            //linkedList.AddNode(70);
            //linkedList.AddNode(30);
            //linkedList.AddNode(56);
            //linkedList.PrintList();
            //linkedList.Pop();
            //linkedList.PrintList();

            linkedList.AddNode(70);
            linkedList.AddNode(30);
            linkedList.AddNode(56);
            linkedList.PrintList();
            //linkedList.PopLast();
            //linkedList.PrintList();
            //Console.WriteLine(linkedList.Search(30));

            int valueToFind = 30;
            int valueToInsert = 40;
            linkedList.InsertAfter(valueToFind, valueToInsert);
            linkedList.PrintList();

            Console.WriteLine(linkedList.Search(40));
            linkedList.Delete(40);
            linkedList.PrintList();
            int size = linkedList.Size();
            Console.WriteLine("Linked List Size: " + size);




        }
    }
}