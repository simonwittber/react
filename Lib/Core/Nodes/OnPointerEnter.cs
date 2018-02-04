namespace DifferentMethods.React
{
    [CoreDecorator(5)]
    [System.Serializable]
    public class OnPointerEnter : DecoratorNode
    {
        public int button;

        protected override NodeState Execute()
        {
            if (Child != null)
            {
                Reactor.QueueForExecution(Child);
            }
            return NodeState.Continue;
        }
    }


}
