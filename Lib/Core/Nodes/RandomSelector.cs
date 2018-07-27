using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{

    /// <summary>
    ///     /// Shuffles the children, then executes them in order until one returns a failure.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class RandomSelector : BranchNode
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
                    case NodeState.Failure:
                    case NodeState.NoResult:
                        break;
                    case NodeState.Success:
                        if (policy == RandomSequencePolicy.AlwaysShuffle || policy == RandomSequencePolicy.ShuffleOnSuccess)
                            Shuffle();
                        return NodeState.Success;
                }
                if (NextChild())
                    continue;
                else
                {
                    if (policy == RandomSequencePolicy.AlwaysShuffle || policy == RandomSequencePolicy.ShuffleOnFailure)
                        Shuffle();
                    return NodeState.Failure;
                }
            }
        }

        public override string ToString()
        {
            return "Random Selector";
        }

        public static string GetMenuPath()
        {
            return "Random/Selector";
        }
    }
}
