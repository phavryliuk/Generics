using System;
using System.Collections.Generic;

namespace StackExample
{
    public class Stack<T>
    {
        private readonly List<T> _stack;

        public Stack()
        {
            _stack = new List<T>();
        }

        public void Push(T obj)
        {
            _stack.Add(obj);
        }

        public T Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("The stack is empty.");

            int lastIndex = _stack.Count - 1;
            T last = _stack[lastIndex];
            _stack.RemoveAt(lastIndex);
            return last;
        }

        public void Clear()
        {
            _stack.Clear();
        }

        public int Count
        {
            get { return _stack.Count; }
        }

        public T Peek()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("The stack is empty.");

            return _stack[_stack.Count - 1];
        }

        public void CopyTo(T[] arr)
        {
            _stack.CopyTo(arr);
        }
    }
}