using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call AudioSource.Play on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_AudioSource_Play_ : LeafNode
    {


        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() {
            Component.Play();
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.AudioSource>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "AudioSource.Play";
        public static string GetMenuPath() => "AudioSource/Function/Play";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.AudioSource), typeof(Function_AudioSource_Play_));

    }
}
