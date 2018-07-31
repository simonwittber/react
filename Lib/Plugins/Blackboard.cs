using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DifferentMethods.React.Components
{
    public class Blackboard : MonoBehaviour
    {
        public string blackboardName = "Global Blackboard";

        static Dictionary<string, float> values = new Dictionary<string, float>();
        static Stack<string> stateStack = new Stack<string>();

        [ContextMenu("Dump")]
        public void Dump()
        {
            foreach (var kv in values)
            {
                Debug.Log(kv.Key + " : " + kv.Value);
            }
        }

        public void PushState(string state)
        {
            stateStack.Push(state);
        }

        public void PopState()
        {
            if (stateStack.Count > 0)
                stateStack.Pop();
        }

        public bool StateIs(string state)
        {
            if (stateStack.Count > 0)
                return stateStack.Peek() == state;
            return false;
        }

        public float Get(string name)
        {
            float v;
            if (values.TryGetValue(blackboardName + "." + name, out v))
            {
                return v;
            }
            return 0f;
        }

        public void Set(string name, bool value)
        {
            values[blackboardName + "." + name] = value ? 1 : 0;
        }

        public bool IsTrue(string name)
        {
            return Get(name) != 0;
        }

        public bool IsFalse(string name)
        {
            return Get(name) == 0;
        }

        public void Set(string name, float value)
        {
            values[blackboardName + "." + name] = value;
        }

        public void Add(string name, float value)
        {
            Set(name, Get(name) + value);
        }

        public void Mul(string name, float value)
        {
            Set(name, Get(name) * value);
        }

        public void Sub(string name, float value)
        {
            Set(name, Get(name) - value);
        }

        public void Div(string name, float value)
        {
            Set(name, Get(name) / value);
        }

        public bool EQ(string name, float value, float epsilon)
        {
            return (Get(name) - value) <= epsilon;
        }

        public bool LT(string name, float value)
        {
            return Get(name) < value;
        }

        public bool LTE(string name, float value)
        {
            return Get(name) <= value;
        }

        public bool GT(string name, float value)
        {
            return Get(name) > value;
        }

        public bool GTE(string name, float value)
        {
            return Get(name) >= value;
        }

    }
}