using System;
using System.Collections.Generic;

namespace 用栈实现队列232
{
    public class MyQueue
    {
        private readonly Stack<int> _in;
        private readonly Stack<int> _out;

        public MyQueue()
        {
            _in = new Stack<int>();
            _out = new Stack<int>();
        }

        public void Push(int x)
        {
            _in.Push(x);
        }

        public int Pop()
        {
            in2out();
            int x = _out.Pop();
            return x;
        }

        public int Peek()
        {
            in2out();
            return _out.Peek();
        }

        private void in2out()
        {
            if (_out.Count <= 0)
            {
                while (_in.Count > 0)
                {
                    int x = _in.Pop();
                    _out.Push(x);
                }
            }
        }

        public bool Empty()
        {
            return _in.Count == 0 && _out.Count == 0;
        }
    }
}
