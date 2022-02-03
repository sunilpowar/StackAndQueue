﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack And Queue");
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.Display();
            /*stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
           /* LinkedList linkedlist = new LinkedList();
            linkedlist.Add(56);
            linkedlist.Add(30);
            linkedlist.Add(40);
            linkedlist.Add(70);
            linkedlist.Display();
            int position = linkedlist.Search(40);
            linkedlist.DeleteNodeAtParticularPosition(position);*/

            Console.ReadLine();
        }
    }
}
