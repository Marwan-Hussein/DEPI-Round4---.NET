using System;

namespace Day9.Classes
{
    internal class Node<T>
    {
        public T Value { get; set; }
        public Node<T>? Down { get; set; }

        public Node(T value=default(T))
        {
            Value = value;
            Down = null;
        }

        public override string ToString() { return Value?.ToString()??"Null"; }

    }
    internal class Stack<T>
    {
        public Node<T>? Top { private set; get;  }
        public int Size { private set; get; }
        public Stack() 
        {
            Size = 0;
            Top = null;
        }

        #region methods
        public void Push(T value)
        {
            Node<T>? node = new Node<T>(value);
            node.Down = Top;
            Top = node;
            ++Size; 
        }
        public T Pop()
        {
            if (Size < 1) 
                throw new NullReferenceException("Stack is empty already!!");

            T top = Top.Value;
            Top = Top.Down;
            --Size;
            return top;

        }
        public T Peek()
        {
            if (Size < 1)
                throw new NullReferenceException("Stack is empty already!!");
            return Top.Value;
        }
        public bool isEmpty() => Size == 0;
        #endregion


    }
}
