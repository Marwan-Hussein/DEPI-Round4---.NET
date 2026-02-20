using System;

namespace Day9.Classes
{
    internal class Node<T>
    {
        public T Value { get; set; }
        public Node<T>? Up { get; set; }
        public Node<T>? Down { get; set; }

        public Node(T value=default(T))
        {
            Value = value;
            Up = null;
            Down = null;
        }

        public override string ToString() { return Value.ToString(); }

    }
    internal class Stack<T>
    {
        Node<T> Peek { set; get;  }
        public int Size { private set; get; }
        public Stack() 
        {
            Size = 0;
            Peek = null;
        }

        #region methods
        public void Push(T value)
        {
            if(Peek is null)
            {
                Peek = new Node<T>(value);
                Peek.Up = Peek.Down = null;
                ++Size;
                return;
            }
            Node<T>? node = new Node<T>(value);
            Peek.Up = node;
            node.Down = Peek;
            Peek = node;
            ++Size; 
            return;
        }
        public void Pop()
        {
            if (Peek is null) 
            { throw new NullReferenceException("Stack is empty already!!"); }
            Node<T> top = Peek;
            Peek = top.Down;
            Peek.Up = null;
            top.Down = null;
            --Size;
        }
        #endregion


    }
}
