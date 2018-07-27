namespace DifferentMethods.React
{
    [System.Serializable]
    [CoreNode]
    public class ContinueNextFrame : LeafNode
    {
        protected override NodeState Execute()
        {
            return NodeState.ContinueNextFrame;
        }
    }


}
