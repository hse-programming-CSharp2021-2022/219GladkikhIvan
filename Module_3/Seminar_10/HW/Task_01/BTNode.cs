using System;
using System.Collections;

namespace Task_01
{
    public class BTNode<ValType>
        where ValType : IComparable
    {
        public ValType Value { get; }
        public int Count { get; private set; }
        
        public BTNode<ValType> RightBranch { get; private set; }
        public BTNode<ValType> LeftBranch { get; private set; }
        
        public BTNode(ValType value, BTNode<ValType> left=null, BTNode<ValType> right=null) 
            => (Value, LeftBranch, RightBranch, Count) = (value, left, right, 1);

        public void InsertValue(ValType newValue)
        {
            if (Value.CompareTo(newValue) < 0)
            {
                if (RightBranch is null)
                {
                    RightBranch = new BTNode<ValType>(newValue);
                    return;
                }
                RightBranch.InsertValue(newValue);
            }
            if (Value.CompareTo(newValue) > 0)
            {
                if (LeftBranch is null)
                {
                    LeftBranch = new BTNode<ValType>(newValue);
                    return;
                }
                LeftBranch.InsertValue(newValue);
            }

            Count++;
        }

        public override string ToString()
            => $"Node | Value:{Value}; Count:{Count}";
    } 
}