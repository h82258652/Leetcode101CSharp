using System.Collections.Generic;

namespace LRU缓存146
{
    public class LRUCache
    {
        private readonly Dictionary<int, DLinkedNode> _cache = new Dictionary<int, DLinkedNode>();
        private readonly int _capacity;
        private readonly DLinkedNode _head;
        private readonly DLinkedNode _tail;
        private int _size;

        public LRUCache(int capacity)
        {
            _size = 0;
            _capacity = capacity;
            // 使用伪头部和伪尾部节点
            _head = new DLinkedNode();
            _tail = new DLinkedNode();
            _head.next = _tail;
            _tail.prev = _head;
        }

        public int Get(int key)
        {
            _cache.TryGetValue(key, out var node);
            if (node == null)
            {
                return -1;
            }

            // 如果 key 存在，先通过哈希表定位，再移到头部
            MoveToHead(node);
            return node.value;
        }

        public void Put(int key, int value)
        {
            _cache.TryGetValue(key, out var node);
            if (node == null)
            {
                // 如果 key 不存在，创建一个新的节点
                DLinkedNode newNode = new DLinkedNode(key, value);
                // 添加进哈希表
                _cache[key] = newNode;
                // 添加至双向链表的头部
                AddToHead(newNode);
                _size++;
                if (_size > _capacity)
                {
                    // 如果超出容量，删除双向链表的尾部节点
                    DLinkedNode tail = RemoveTail();
                    // 删除哈希表中对应的项
                    _cache.Remove(tail.key);
                    _size--;
                }
            }
            else
            {
                // 如果 key 存在，先通过哈希表定位，再修改 value，并移到头部
                node.value = value;
                MoveToHead(node);
            }
        }

        private void AddToHead(DLinkedNode node)
        {
            node.prev = _head;
            node.next = _head.next;
            _head.next.prev = node;
            _head.next = node;
        }

        private void MoveToHead(DLinkedNode node)
        {
            RemoveNode(node);
            AddToHead(node);
        }

        private void RemoveNode(DLinkedNode node)
        {
            node.prev.next = node.next;
            node.next.prev = node.prev;
        }

        private DLinkedNode RemoveTail()
        {
            DLinkedNode res = _tail.prev;
            RemoveNode(res);
            return res;
        }

        public class DLinkedNode
        {
            public int key;
            public DLinkedNode next;
            public DLinkedNode prev;
            public int value;

            public DLinkedNode()
            {
            }

            public DLinkedNode(int key, int value)
            {
                this.key = key;
                this.value = value;
            }
        }
    }

    public class LRUCache2
    {
        private readonly LinkedList<Node> _cache;

        private readonly int _capacity;

        private readonly Dictionary<int, Node> _hash;

        public LRUCache2(int capacity)
        {
            _capacity = capacity;
            _hash = new Dictionary<int, Node>();
            _cache = new LinkedList<Node>();
        }

        public int Get(int key)
        {
            if (!_hash.ContainsKey(key))
            {
                return -1;
            }

            var node = _hash[key];
            _cache.Remove(node);
            _cache.AddLast(node);
            return node.value;
        }

        public void Put(int key, int value)
        {
            if (_hash.ContainsKey(key))
            {
                var node = _hash[key];
                _cache.Remove(node);
                _cache.AddLast(node);
                node.value = value;
                return;
            }

            if (_hash.Count < _capacity)
            {
                var node = new Node() { key = key, value = value };
                _cache.AddLast(node);
                _hash[key] = node;
            }
            else
            {
                _hash.Remove(_cache.First.Value.key);
                _cache.RemoveFirst();

                var node = new Node() { key = key, value = value };
                _cache.AddLast(node);
                _hash[key] = node;
            }
        }

        internal class Node
        {
            public int key;
            public int value;
        }
    }
}
