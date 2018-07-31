using System;

using System.Collections;
using System.Collections.Generic;



namespace DifferentMethods.React
{
    /// <summary>
    /// Each time this branch is run, it will execute the first child, then the second, etc.
	/// After all children have been executed, the branch will start again.
    /// </summary>
	[System.Serializable]
    [CoreNode]
    public class ToDo : BranchNode
    {
        protected override NodeState Execute()
        {
            var result = ExecuteNode(ActiveChild);
            if (result == NodeState.ContinueNextFrame)
            {
                return result;
            }
            NextChild();
            return NodeState.NoResult;
        }

    }

}







