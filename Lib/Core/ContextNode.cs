using UnityEngine;

namespace DifferentMethods.React
{
    [System.Serializable]
    public class ContextNode : DecoratorNode
    {

        protected void SetActiveGameObject(GameObject gameObject)
        {
            Context.Update(gameObject);
        }

        public override void OnEnable()
        {
            base.OnEnable();
            Context = ReactContext.New(this);
        }

    }

}
