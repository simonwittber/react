using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    public enum RandomSequencePolicy
    {
        ShuffleOnSuccess,
        ShuffleOnFailure,
        AlwaysShuffle
    }

    /// <summary>
    /// Shuffles the children, then executes them in order until one returns a success.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class RandomSequence : BranchNode
    {

        public RandomSequencePolicy policy;

        void Shuffle()
        {
            var n = Children.Count;
            for (var i = 0; i < n; i++)
            {
                int r = i + (int)(Random.value * (n - i));
                var t = Children[r];
                Children[r] = Children[i];
                Children[i] = t;
            }
        }

        protected override NodeState Execute()
        {
            while (true)
            {
                switch (ExecuteNode(ActiveChild))
                {
                    case NodeState.Success:
                    case NodeState.NoResult:
                        break;
                    case NodeState.Failure:
                        if (policy == RandomSequencePolicy.AlwaysShuffle || policy == RandomSequencePolicy.ShuffleOnFailure)
                            Shuffle();
                        return NodeState.Failure;
                    case NodeState.ContinueNextFrame:
                        return NodeState.ContinueNextFrame;
                }
                if (NextChild())
                    continue;
                else
                {
                    if (policy == RandomSequencePolicy.AlwaysShuffle || policy == RandomSequencePolicy.ShuffleOnSuccess)
                        Shuffle();
                    return NodeState.Success;
                }
            }
        }

        public override string ToString() => "Random Sequence";

        public static string GetMenuPath() => "Random/Sequence";
    }
}
