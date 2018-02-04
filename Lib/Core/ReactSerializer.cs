using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace DifferentMethods.React
{

    [Serializable]
    public class ReactSerializer
    {
        public List<UnityEngine.Object> references = new List<UnityEngine.Object>();
        public List<string> tokens = new List<string>();

        static public HashSet<string> missingTypes = new HashSet<string>();

        public bool IsMissingTypes { get; private set; }

        public void Save(IReactor reactor)
        {
            Clear();
            Serialize(reactor.Root);
        }

        public void Load(IReactor reactor)
        {
            reactor.Root = ((Root)Deserialize());
        }

        public void Clear()
        {
            references.Clear();
            tokens.Clear();
        }

        public BaseNode Deserialize()
        {
            IsMissingTypes = false;
            var queue = new Queue<string>(tokens);
            var objects = new Queue<UnityEngine.Object>(references);
            var parents = new Stack<IParentNode>();
            Type type = null;
            BaseNode instance = null;
            BaseNode lastParent = null;
            while (queue.Count > 0)
            {
                var cmd = queue.Dequeue();
                switch (cmd)
                {
                    case "null":
                        Debug.LogError("WTF");
                        break;
                    case "new":
                        var typeName = queue.Dequeue();
                        type = ReactTypeRegister.Find(typeName);
                        if (type == null)
                        {
                            missingTypes.Add(typeName);
                            IsMissingTypes = true;
                            Debug.Log("Missing Type: " + typeName);
                            return null;
                        }
                        instance = Activator.CreateInstance(type) as BaseNode;
                        if (parents.Count > 0)
                            parents.Peek().Add(instance);
                        break;
                    case "{":
                        var fcmd = queue.Dequeue();
                        while (fcmd != "}")
                        {
                            var fi = type.GetField(fcmd);
                            if (fi == null)
                            {
                                Debug.LogError(fcmd);
                            }
                            else
                            {
                                if (fi.FieldType.IsSubclassOf(typeof(UnityEngine.Object)))
                                    fi.SetValue(instance, objects.Dequeue());
                                else
                                    fi.SetValue(instance, ConvertToValue(fi.FieldType, queue.Dequeue()));
                            }
                            fcmd = queue.Dequeue();
                        }
                        break;
                    case "[":
                        parents.Push((IParentNode)instance);
                        break;
                    case "]":
                        lastParent = (BaseNode)parents.Pop();
                        break;
                }
            }
            return lastParent;
        }

        byte[] ToBytes(string repr, int index)
        {
            var u = uint.Parse(repr.Substring(index * 8, 8), System.Globalization.NumberStyles.HexNumber);
            return BitConverter.GetBytes(u);
        }

        object ConvertToValue(Type t, string obj)
        {
            if (t == typeof(string))
                return obj;
            if (t == typeof(int))
                return BitConverter.ToInt32(ToBytes(obj, 0), 0);
            if (t == typeof(bool))
                return obj == "T";
            if (t == typeof(float))
                return BitConverter.ToSingle(ToBytes(obj, 0), 0);
            if (t == typeof(Vector3))
            {
                return new Vector3(
                    BitConverter.ToSingle(ToBytes(obj, 0), 0),
                    BitConverter.ToSingle(ToBytes(obj, 1), 0),
                    BitConverter.ToSingle(ToBytes(obj, 2), 0)
                );
            }
            if (t == typeof(Vector2))
            {
                return new Vector2(
                    BitConverter.ToSingle(ToBytes(obj, 0), 0),
                    BitConverter.ToSingle(ToBytes(obj, 1), 0)
                );
            }
            if (t == typeof(Vector4))
            {
                return new Vector4(
                    BitConverter.ToSingle(ToBytes(obj, 0), 0),
                    BitConverter.ToSingle(ToBytes(obj, 1), 0),
                    BitConverter.ToSingle(ToBytes(obj, 2), 0),
                    BitConverter.ToSingle(ToBytes(obj, 3), 0)
                );
            }
            if (t == typeof(Color))
            {
                return new Color(
                    BitConverter.ToSingle(ToBytes(obj, 0), 0),
                    BitConverter.ToSingle(ToBytes(obj, 1), 0),
                    BitConverter.ToSingle(ToBytes(obj, 2), 0),
                    BitConverter.ToSingle(ToBytes(obj, 3), 0)
                );
            }
            if (t.IsEnum)
                return BitConverter.ToInt32(ToBytes(obj, 0), 0);

            if (t == typeof(LayerMask))
            {
                LayerMask lm = BitConverter.ToInt32(ToBytes(obj, 0), 0);
                return lm;
            }

            throw new NotImplementedException("Serializer: " + t.ToString());
        }

        string ToRepr(float obj)
        {
            return BitConverter.ToUInt32(BitConverter.GetBytes(obj), 0).ToString("X8");
        }

        string ToRepr(int obj)
        {
            return BitConverter.ToUInt32(BitConverter.GetBytes(obj), 0).ToString("X8");
        }

        string ToRepr(uint obj)
        {
            return obj.ToString("X8");
        }

        string ConvertToRepr(object obj)
        {
            if (obj == null) return "";
            var t = obj.GetType();
            if (t == typeof(string))
                return (string)obj;
            if (t == typeof(int))
                return ToRepr((int)obj);
            if (t == typeof(bool))
                return (bool)obj ? "T" : "F";
            if (t == typeof(float))
                return ToRepr((float)obj);
            if (t == typeof(Vector3))
            {
                var v = (Vector3)obj;
                return ToRepr(v.x) + ToRepr(v.y) + ToRepr(v.z);
            }
            if (t == typeof(Vector2))
            {
                var v = (Vector2)obj;
                return ToRepr(v.x) + ToRepr(v.y);
            }
            if (t == typeof(Vector4))
            {
                var v = (Vector4)obj;
                return ToRepr(v.x) + ToRepr(v.y) + ToRepr(v.z) + ToRepr(v.w);
            }
            if (t == typeof(Color))
            {
                var v = (Color)obj;
                return ToRepr(v.r) + ToRepr(v.g) + ToRepr(v.b) + ToRepr(v.a);
            }
            if (t.IsEnum)
                return ToRepr((int)obj);
            if (t == typeof(LayerMask))
                return ToRepr(((LayerMask)obj).value);

            throw new NotImplementedException("Serializer: " + obj.ToString());
        }

        public void Serialize(BaseNode node)
        {
            if (node == null)
            {
                tokens.Add("null");
            }
            else
            {
                tokens.Add("new");
                tokens.Add(node.GetType().AssemblyQualifiedName);
                tokens.Add("{");
                foreach (var fi in ReactTypeRegister.GetFields(node))
                {
                    tokens.Add(fi.Name);
                    var o = fi.GetValue(node);
                    if (fi.FieldType.IsSubclassOf(typeof(UnityEngine.Object)))
                        references.Add(o as UnityEngine.Object);
                    else
                        tokens.Add(ConvertToRepr(o));
                }
                tokens.Add("}");
                var parent = node as IParentNode;
                if (parent != null)
                {
                    tokens.Add("[");
                    foreach (var child in parent.GetChildren())
                    {
                        Serialize(child);
                    }
                    tokens.Add("]");
                }
            }
        }

    }
}