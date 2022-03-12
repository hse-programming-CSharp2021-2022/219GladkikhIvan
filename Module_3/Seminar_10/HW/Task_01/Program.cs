using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var bt = new BinaryTree<int>(new BTNode<int>(rnd.Next(-10, 10)));
            for (var i = 0; i < 10; i++)
                bt.Insert(rnd.Next(-10, 10));
            bt.Print();
        }
    }
}