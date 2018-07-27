namespace DifferentMethods.React
{
    [System.Serializable]
    [CoreNode]
    public class Failure : LeafNode
    {
        protected override NodeState Execute()
        {
            return NodeState.Failure;
        }
    }


}
