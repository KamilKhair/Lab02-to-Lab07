using System.Collections;
using System.Collections.Generic;

namespace GenericApp
{
    public interface IMultiDictionary<TKey, TValue>
    {
        void Add(TKey key, TValue value);
        bool Remove(TKey key);
        bool Remove(TKey key, TValue value);
        void Clear();
        bool ContainsKey(TKey key);
        bool Contains(TKey key, TValue value);
        ICollection<TKey> Keys { get; }
        ICollection<TValue> Values { get; }
        int Count { get; }
    }

    public class MultiDictionary<TKey, TValue> : IMultiDictionary<TKey, TValue>, IEnumerable<KeyValuePair<TKey, IEnumerable<TValue>>>
    {
        public MultiDictionary()
        {
            Dictionary = new Dictionary<TKey, LinkedList<TValue>>();
            Count = 0;
        }

        private Dictionary<TKey, LinkedList<TValue>> Dictionary { get;}


        public void Add(TKey key, TValue value)
        {
            if (Dictionary.ContainsKey(key))
            {
                Dictionary[key].AddLast(value);
            }
            else
            {
                Dictionary.Add(key, new LinkedList<TValue>());
                Dictionary[key].AddLast(value);
            }
            ++Count;
        }

        public bool Remove(TKey key)
        {
            if (!Dictionary.ContainsKey(key)) return false;
            Count -= Dictionary[key].Count;
            Dictionary.Remove(key);
            return true;
        }

        public bool Remove(TKey key, TValue value)
        {
            if (!Dictionary.ContainsKey(key)) return false;
            if (!Dictionary[key].Remove(value)) return false;
            if (Dictionary[key].Count == 0)
            {
               Dictionary.Remove(key);
            }
            --Count;
            return true;
        }

        public void Clear()
        {
            Dictionary.Clear();
            Count = 0;
        }

        public bool ContainsKey(TKey key)
        {
            return Dictionary.ContainsKey(key);
        }

        public bool Contains(TKey key, TValue value)
        {
            if (!Dictionary.ContainsKey(key)) return false;
            return Dictionary[key].Contains(value);
        }

       

        public ICollection<TKey> Keys => Dictionary.Keys;

        public ICollection<TValue> Values
        {
            get
            {
                var list = new List<TValue>();
                foreach (var key in Dictionary)
                {
                    foreach (var value in key.Value)
                    {
                        if (!list.Contains(value))
                        {
                            list.Add(value);
                        }
                    }
                }
                return list;
            }
        }
        public int Count { get; private set; }

        public IEnumerator<KeyValuePair<TKey, IEnumerable<TValue>>> GetEnumerator()
        {
            var list = new List<KeyValuePair<TKey, IEnumerable<TValue>>>();

            foreach (var item in Dictionary)
            {
                list.Add(new KeyValuePair<TKey, IEnumerable<TValue>>(item.Key, item.Value));
            }

            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}