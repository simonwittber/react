using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    public class TaskList
    {
        Queue<BaseNode> actions = new Queue<BaseNode>();
        Queue<BaseNode> pendingActions = new Queue<BaseNode>();

        public void Enqueue(BaseNode node)
        {
            //If a node is already running, we don't try and start it again.
            if (!node.inTaskQueue)
            {
                //These two lines preservce the Context of the node, so that parent nodes can 
                //continue independently without changing the context of this running child.
                var currentContext = node.Context;
                node.Context = currentContext;
                actions.Enqueue(node);
                node.inTaskQueue = true;
            }
        }

        public void Update()
        {
            while (actions.Count > 0)
            {
                var node = actions.Dequeue();
                var result = BaseNode.ExecuteNode(node);
                if (result == NodeState.CallAgain)
                    pendingActions.Enqueue(node);
                else
                    node.inTaskQueue = false;
            }
            var T = actions;
            actions = pendingActions;
            pendingActions = T;
        }

    }

}