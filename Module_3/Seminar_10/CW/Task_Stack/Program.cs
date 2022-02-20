using System;
using System.Collections.Generic;

namespace Task_Stack
{
    class MyStack<T>
    {
        class Node<T>
        {
            internal T value;
            internal Node<T> prev;

            internal Node(T value, Node<T> prev)
                => (this.value, this.prev) = (value, prev);
        }

        private Node<T> head = null;
        private Node<T> tail = null;
        private int size = 0;
        public bool IsEmpty()
            => head == null;
        
        public void Push(T t)
        {
            if (IsEmpty())
            {
                head = new Node<T>(t, null);
                tail = head;
            }
            else
            {
                tail = new Node<T>(t, tail);
            }

            size++;
        }

        public int Size()
            => size;
        
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty.");
            }

            var val = tail.value;
            tail = tail.prev;
            if (tail == null)
                head = null;
            size--;
            return val;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty.");
            }

            return tail.value;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var myStack = new MyStack<int>();
            
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            Console.WriteLine($"Size: {myStack.Size()}");
            Console.WriteLine($"Peek: {myStack.Peek()}");
            Console.WriteLine($"Pop: {myStack.Pop()}");
            Console.WriteLine($"Pop: {myStack.Pop()}");
            Console.WriteLine($"Pop: {myStack.Pop()}");
            try
            {
                Console.WriteLine($"Pop: {myStack.Pop()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);    
            }

            Console.WriteLine("**********");
            
            var stack = new Stack<string>();
            stack.Push("one");
            stack.Push("two");
            stack.Push("three");
            Console.WriteLine($"Size: {stack.Count}");
            Console.WriteLine($"Peek: {stack.Peek()}");
            Console.WriteLine($"Pop: {stack.Pop()}");
            Console.WriteLine($"Pop: {stack.Pop()}");
            Console.WriteLine($"Pop: {stack.Pop()}");
            try
            {
                Console.WriteLine($"Pop: {stack.Pop()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);    
            }
        }
    }
}