namespace DifferentMethods.React
{
    /// <summary>
    /// This decorator will execute it's child forever.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class Repeat : DecoratorNode
    {
        protected override NodeState Execute()
        {
            if (Child != null)
            {
                ExecuteNode(Child);
            }
            return NodeState.ContinueNextFrame;
        }
    }

}
