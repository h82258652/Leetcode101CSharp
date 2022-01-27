using FluentAssertions;
using Xunit;

namespace 最小栈155
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            minStack.GetMin().Should().Be(-3);
            minStack.Pop();
            minStack.Top().Should().Be(0);
            minStack.GetMin().Should().Be(-2);
        }
    }
}
