
using System.Collections;
using System.Collections.Generic;

namespace DifferentMethods.React
{
    public class ActionPool
    {
        static public int maxFreeListSize = 7;
        static Dictionary<System.Type, Queue<ReactAction>> pool = new Dictionary<System.Type, Queue<ReactAction>>();

        static void Clear()
        {
            pool.Clear();
        }

        static public T Take<T>() where T : ReactAction, new()
        {
            Queue<ReactAction> freeList;
            if (pool.TryGetValue(typeof(T), out freeList))
            {
                if (freeList.Count > 0)
                {
                    var rc = freeList.Dequeue();
                    rc.Reset();
                    return (T)rc;
                }
            }
            return new T();
        }

        static public void Recycle(ReactAction rc)
        {
            Queue<ReactAction> freeList;
            var type = rc.GetType();
            if (!pool.TryGetValue(type, out freeList))
            {
                freeList = new Queue<ReactAction>();
                pool.Add(type, freeList);
            }
            if (freeList.Count < maxFreeListSize)
            {
                freeList.Enqueue(rc);
            }
        }

    }
}