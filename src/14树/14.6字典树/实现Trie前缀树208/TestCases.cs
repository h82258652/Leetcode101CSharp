using FluentAssertions;
using Xunit;

namespace 实现Trie前缀树208
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            Trie trie = new Trie();
            trie.Insert("apple");
            trie.Search("apple").Should().BeTrue();
            trie.Search("app").Should().BeFalse();
            trie.StartsWith("app").Should().BeTrue();
            trie.Insert("app");
            trie.Search("app").Should().BeTrue();
        }
    }
}
