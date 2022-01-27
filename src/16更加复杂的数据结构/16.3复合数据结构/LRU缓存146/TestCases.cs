using FluentAssertions;
using Xunit;

namespace LRU缓存146
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var lruCache = new LRUCache(2);
            lruCache.Put(1, 1);
            lruCache.Put(2, 2);
            lruCache.Get(1).Should().Be(1);
            lruCache.Put(3, 3);
            lruCache.Get(2).Should().Be(-1);
            lruCache.Put(4, 4);
            lruCache.Get(1).Should().Be(-1);
            lruCache.Get(3).Should().Be(3);
            lruCache.Get(4).Should().Be(4);
        }

        [Fact]
        public void Test2()
        {
            var lruCache = new LRUCache(2);
            lruCache.Put(2, 1);
            lruCache.Put(2, 2);
            lruCache.Get(2).Should().Be(2);
            lruCache.Put(1, 1);
            lruCache.Put(4, 1);
            lruCache.Get(2).Should().Be(-1);
        }
    }
}
