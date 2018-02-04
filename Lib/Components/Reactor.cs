using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Profiling;
using DifferentMethods.Extensions.Collections;

namespace DifferentMethods.React
{
    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class Reactor : MonoBehaviour, ISerializationCallbackReceiver, IReactor
    {

        public List<Reactor> libraries = new List<Reactor>();
        public Root Root
        {
            get; set;
        }

        public bool goLarge = false;
        public bool showExplorer = false;

        [NonSerialized] public BaseNode hotNode;
        [HideInInspector] [SerializeField] List<int> hotNodePath = new List<int>();

        [SerializeField] ReactSerializer serializer;
        Dictionary<string, Label> labels = new Dictionary<string, Label>();
        Dictionary<string, OnMessage> messageReceivers = new Dictionary<string, OnMessage>();
        TaskList taskList = new TaskList();
        PrioritySet<Delay> waitingNodes = new PrioritySet<Delay>();

        [NonSerialized] public bool isMissingTypes = false;
        Dictionary<string, SuperNode> exports = new Dictionary<string, SuperNode>();


        void Reset()
        {
            Root = new Root();
        }

        public SuperNode GetExport(string superID)
        {
            try
            {
                return exports[superID];
            }
            catch (KeyNotFoundException)
            {
                Log("Error", $"Could not load export '{superID}'");
                return null;
            }
        }

        public void RegisterExport(SuperNode node)
        {
            if (!string.IsNullOrEmpty(node.id))
            {
                Log("Registering Export", node.id);
                exports[node.id] = node;
            }
        }

        public IEnumerable<SuperNode> Exports
        {
            get
            {
                return exports.Values;
            }
        }

        public void RegisterReceiver(OnMessage node)
        {
            if (!string.IsNullOrEmpty(node.id))
            {
                Log("Registering Message Receiver", node.id);
                messageReceivers[node.id] = node;
            }
        }

        public void ReceiveMessage(string message, GameObject sender)
        {
            OnMessage node;
            if (messageReceivers.TryGetValue(message, out node))
            {
                BaseNode.ExecuteNode(node);
            }
            else
            {
                Log("Warning", $"No message receiver for {message}.");
            }
        }

        public Label GetLabel(string name)
        {
            return labels[name];
        }

        public void QueueForExecution(BaseNode node)
        {
            taskList.Enqueue(node);
        }

        public void DelayExecution(Delay node)
        {
            waitingNodes.Push(node);
        }

        public void OnEnable()
        {
            AddRequiredComponents();
            EnableAllNodes();
            if (Application.isPlaying) StartCoroutine(Updater());
        }

        public void EnableAllNodes()
        {
            if (Root == null) return;
            foreach (var node in Root.AllDescendants)
                node.OnValidate();
            foreach (var node in Root.AllDescendants)
                node.OnEnable();
        }

        void AddRequiredComponents()
        {
            if (Root != null)
                foreach (var node in Root.Children)
                {
                    if (node is OnStart)
                        BaseNode.ExecuteNode(node);
                    if (node is OnCollisionEnter)
                        RequireComponent<ReceiveOnCollisionEnter>().node = node;
                    if (node is OnCollisionExit)
                        RequireComponent<ReceiveOnCollisionExit>().node = node;
                    if (node is OnCollisionStay)
                        RequireComponent<ReceiveOnCollisionStay>().node = node;
                    if (node is OnTriggerEnter)
                        RequireComponent<ReceiveOnTriggerEnter>().node = node;
                    if (node is OnTriggerExit)
                        RequireComponent<ReceiveOnTriggerExit>().node = node;
                    if (node is OnTriggerStay)
                        RequireComponent<ReceiveOnTriggerStay>().node = node;
                    if (node is OnPointerClick)
                        RequireComponent<ReceiveOnPointerClick>().node = node;
                    if (node is OnPointerEnter)
                        RequireComponent<ReceiveOnPointerEnter>().node = node;
                    if (node is OnPointerExit)
                        RequireComponent<ReceiveOnPointerExit>().node = node;
                }
        }

        IEnumerator Updater()
        {
            while (true)
            {
                Profiler.BeginSample("React", this);
                taskList.Update();
                while (!waitingNodes.IsEmpty && waitingNodes.First.IsReady)
                {
                    var top = waitingNodes.Pop();
                    BaseNode.ExecuteNode(top.Child);
                }
                Profiler.EndSample();
                yield return null;
            }
        }

        public T RequireComponent<T>() where T : Component
        {
            var component = gameObject.GetComponent<T>();
            if (component == null)
                component = gameObject.AddComponent<T>();
            return component;
        }

        public void OnAfterDeserialize()
        {
            serializer.Load(this);
            if (Root != null)
            {
                Root.OnAfterDeserialize(null, this);
                LoadHotNodeFromPath();
            }
        }

        public void OnBeforeSerialize()
        {
            if (serializer == null || serializer.IsMissingTypes) return;
            serializer.Save(this);
            hotNodePath.Clear();
            SaveHotNodePath(hotNode);
        }

        void LoadHotNodeFromPath()
        {
            var node = Root as BaseNode;
            foreach (var index in hotNodePath)
                if (node != null)
                {
                    if (node.ChildCount >= index)
                    {
                        var parentNode = ((IParentNode)node);
                        try
                        {
                            node = parentNode.GetChild(index);
                        }
                        catch (IndexOutOfRangeException)
                        {
                            node = Root;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            hotNode = node as BaseNode;
        }

        void SaveHotNodePath(BaseNode n)
        {
            if (n == null) return;
            var p = n.nodeParent as IParentNode;
            if (p != null)
            {
                var index = p.IndexOf(n);
                hotNodePath.Insert(0, index);
                SaveHotNodePath(p as BaseNode);
            }
        }

        public void Log(string msg)
        {
            Debug.Log($"<color=cyan>{msg}</color>", this);
        }

        public void Log(string heading, string msg)
        {
            Debug.Log($"<color=cyan><b>{heading}</b>: {msg}</color>", this);
        }
    }
}