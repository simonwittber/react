using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    public class Event<T> : System.IDisposable where T : Event<T>, new()
    {
        static Stack<T> pool = new Stack<T>();
        static List<System.Action<T>> subscribers = new List<System.Action<T>>();

        public static T New()
        {
            T ev;
            if (pool.Count > 0)
                ev = pool.Pop();
            else
                ev = new T();
            return ev;
        }

        public static void Dispose(T ev) => pool.Push(ev);

        public T Publish()
        {
            var ev = (T)this;
            for (int i = 0, count = subscribers.Count; i < count; i++)
                subscribers[i](ev);
            return ev;
        }

        public static void Subscribe(System.Action<T> evListener)
        {
            var idx = subscribers.IndexOf(evListener);
            if (idx < 0)
                subscribers.Add(evListener);
        }

        public static void Unsubscribe(System.Action<T> evListener)
        {
            var idx = subscribers.IndexOf(evListener);
            if (idx >= 0)
            {
                subscribers[idx] = subscribers[subscribers.Count - 1];
                subscribers.RemoveAt(subscribers.Count - 1);
            }
        }

        public static void Clear() => subscribers.Clear();

        public void Dispose() => Dispose((T)this);
    }
}