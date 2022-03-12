using System;

namespace Task_01
{
    public class BinaryTree<ElemType>
        where ElemType : IComparable
    {
        public BTNode<ElemType> Root { get; private set; }
        private bool IsEmpty => Root is null;

        public BinaryTree(BTNode<ElemType> root)
            => Root = root;
        
        public void Insert(ElemType value)
        {
            if (IsEmpty)
            {
                Root = new BTNode<ElemType>(value);
                return;
            }
            Root.InsertValue(value);
        }
        
        public void Preorder(BTNode<ElemType> root)
        {
            if (root is null)
                return;
            
            Preorder(root.LeftBranch);
            Console.WriteLine($"{root} ");
            Preorder(root.RightBranch);
        }
        
        public void Inorder(BTNode<ElemType> root)
        {
            if (root is null)
                return;
            
            Inorder(root.RightBranch);
            Console.WriteLine($"{root} ");
            Inorder(root.LeftBranch);
        }

        public void Print()
        {
            if (IsEmpty)
            {
                Console.WriteLine("The tree is empty");
                return;
            }
            
            Preorder(Root);
        }
    }
}