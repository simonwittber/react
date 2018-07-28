using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Tween.Move on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_Tween_Move_transform_position_T : LeafNode
    {
        public UnityEngine.Transform transform;
        public UnityEngine.Vector3 position;
        public float T;

        
        protected override NodeState Execute() {
            DifferentMethods.React.Components.Tween.Move(transform, position, T);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Tween.Move";
        public static string GetMenuPath() => "Tween/Function/Move";
        public static string Signature() => " (transform,position,T)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Tween);
    }
}
