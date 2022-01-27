using System.Collections.Generic;

namespace 最小栈155
{
    public class MinStack
    {
        private Stack<int> _dataStack;
        private Stack<int> _minStack;

        public MinStack()
        {
            _dataStack = new Stack<int>();
            _minStack = new Stack<int>();
        }

        public void Push(int val)
        {
            _dataStack.Push(val);
            if (_minStack.Count <= 0 || val <= _minStack.Peek())
            {
                _minStack.Push(val);
            }
        }

        public void Pop()
        {
            int x = _dataStack.Pop();
            if (x == _minStack.Peek())
            {
                _minStack.Pop();
            }
        }

        public int Top()
        {
            return _dataStack.Peek();
        }

        public int GetMin()
        {
            return _minStack.Peek();
        }
    }
}
