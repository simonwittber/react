using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    [System.Serializable]
    public class GameObjectList : IList<GameObject>
    {
        public List<GameObject> items = new List<GameObject>();

        public GameObject this[int index] { get { return ((IList<GameObject>)items)[index]; } set { ((IList<GameObject>)items)[index] = value; } }

        public int Count => ((IList<GameObject>)items).Count;

        public bool IsReadOnly => ((IList<GameObject>)items).IsReadOnly;

        public void Add(GameObject item)
        {
            ((IList<GameObject>)items).Add(item);
        }

        public void Clear()
        {
            ((IList<GameObject>)items).Clear();
        }

        public bool Contains(GameObject item)
        {
            return ((IList<GameObject>)items).Contains(item);
        }

        public void CopyTo(GameObject[] array, int arrayIndex)
        {
            ((IList<GameObject>)items).CopyTo(array, arrayIndex);
        }

        public IEnumerator<GameObject> GetEnumerator()
        {
            return ((IList<GameObject>)items).GetEnumerator();
        }

        public int IndexOf(GameObject item)
        {
            return ((IList<GameObject>)items).IndexOf(item);
        }

        public void Insert(int index, GameObject item)
        {
            ((IList<GameObject>)items).Insert(index, item);
        }

        public bool Remove(GameObject item)
        {
            return ((IList<GameObject>)items).Remove(item);
        }

        public void RemoveAt(int index)
        {
            ((IList<GameObject>)items).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IList<GameObject>)items).GetEnumerator();
        }
    }

}