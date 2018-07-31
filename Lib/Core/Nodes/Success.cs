namespace DifferentMethods.React
{
    [System.Serializable]
    [CoreNode]
    public class Success : LeafNode
    {
        protected override NodeState Execute()
        {
            return NodeState.Success;
        }
    }
}
