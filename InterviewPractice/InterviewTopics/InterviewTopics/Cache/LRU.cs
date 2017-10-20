using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics.Cache
{
    public class LRU<TKey, TValue>
    {
        private readonly Dictionary<TKey, Node> _entries;
        private readonly int capacity;
        private Node head;
        private Node tail;
        private class Node
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }

            public Node(TKey key,TValue value)
            {
                this.Key = key;
                this.Value = value;
            }
        }

        public LRU(int capacity = 16)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException("capcity should greater than 10.");
            }
            this.capacity = capacity;
            _entries = new Dictionary<TKey, Node>(this.capacity);
            head = null;
        }

        public void setValue(TKey key,TValue value)
        {
            if (_entries.ContainsKey(key))
            {
                Node old;
                _entries.TryGetValue(key, out old);
                old.Value = value;
                //remove(old)
                //sethead
            }
            else
            {
                Node newNode = new Node(key, value);
                if(_entries.Count>=capacity)
                {
                    _entries.Remove(tail.Key);
                    //remove(end);
                    //sethead
                }
                else
                {
                    //sethead
                }
                _entries.Add(key, newNode);
            }
        }
    }
}
