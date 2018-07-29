using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Animator.Play on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animator_Play_stateName_layer : LeafNode
    {
        public string stateName;
        public int layer;


        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.Play(stateName, layer);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animator>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.Play";
        public static string GetMenuPath() => "Animator/Function/Play/(stateName, layer)";
        public static string Signature() => " (stateName,layer)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_Play_stateName_layer));

    }
}