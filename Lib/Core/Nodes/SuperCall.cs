using System.Collections.Generic;
using DifferentMethods.Extensions.Serialization;
using UnityEngine;

namespace DifferentMethods.React
{
    [System.Serializable]
    public class SuperCall : BranchNode
    {
        public Reactor lib;
        public string id;
        SuperNode import;

        public override void OnValidate()
        {
            var export = lib.GetExport(id);
            if (export != null)
            {
                var existing = new Dictionary<string, GraftPoint>();
                var required = new Dictionary<string, GraftPoint>();

                foreach (var c in Children)
                {
                    var p = c as GraftPoint;
                    if (p != null)
                        existing.Add(p.id, p);
                }
                foreach (var p in export.ParameterNodes)
                    required.Add(p.id, p);
                foreach (var i in existing)
                {
                    if (!required.ContainsKey(i.Key))
                        Remove(i.Value);
                }
                foreach (var i in required)
                {
                    if (!existing.ContainsKey(i.Key))
                    {
                        Add(BaseNode.Clone(i.Value));
                    }
                }

            }
        }

        public override void OnEnable()
        {
            if (Application.isPlaying)
            {
                var export = lib.GetExport(id);
                if (export != null)
                {
                    import = BaseNode.Clone(export) as SuperNode;
                    import.OnAfterDeserialize(this, Reactor);
                    import.OnEnable();
                    var args = new Dictionary<string, GraftPoint>();
                    foreach (var c in Children)
                    {
                        var p = c as GraftPoint;
                        if (p != null)
                            args[p.id] = p;
                    }
                    foreach (var p in import.ParameterNodes)
                    {
                        if (args.ContainsKey(p.id))
                            p.ReplaceWith(args[p.id].Child);
                    }
                    ReplaceWith(import.Child);
                }
            }
        }

        protected override NodeState Execute()
        {
            if (import == null)
                return NodeState.Failure;
            return BaseNode.ExecuteNode(import);
        }

        public override string ToString()
        {
            return "External";
        }
    }


}
