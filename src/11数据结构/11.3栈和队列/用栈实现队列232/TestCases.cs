using FluentAssertions;
using Xunit;

namespace 用栈实现队列232
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var myQueue = new MyQueue();
            myQueue.Push(1);
            myQueue.Push(2);
            myQueue.Peek().Should().Be(1);
            myQueue.Pop().Should().Be(1);
            myQueue.Empty().Should().BeFalse();
        }
    }
}
