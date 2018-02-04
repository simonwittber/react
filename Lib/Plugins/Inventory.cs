using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    public class Inventory : MonoBehaviour
    {

        Dictionary<string, int> items = new Dictionary<string, int>();

        public IEnumerable<KeyValuePair<string, int>> Items
        {
            get
            {
                foreach (var kv in items)
                    yield return kv;
            }
        }

        public void Increment(string item)
        {
            if (items.ContainsKey(item))
                items[item] += 1;
            else
                items[item] = 1;
        }

        public void Decrement(string item)
        {
            if (items.ContainsKey(item))
            {
                items[item] -= 1;
                if (items[item] == 0) items.Remove(item);
            }
        }

        public bool HasItem(string item)
        {
            return items.ContainsKey(item);
        }

        public bool HasItem(string item, int count)
        {
            return items.ContainsKey(item) && items[item] >= count;
        }

    }
}