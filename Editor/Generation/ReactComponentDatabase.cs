using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace DifferentMethods.React
{
    [CreateAssetMenu]
    public class ReactComponentDatabase : ScriptableObject
    {
        public MonoScript[] scripts;
    }
}
