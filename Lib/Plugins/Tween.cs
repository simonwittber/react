using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    public class Tween : MonoBehaviour
    {
        public AnimationCurve[] curves;
        Vector3 originPosition;
        Quaternion originRotation;
        static Tween instance;


        void Reset()
        {
            curves = new AnimationCurve[2];
            curves[0] = new AnimationCurve();
            curves[1] = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));
        }

        void Awake()
        {
            if (instance != null)
                DestroyImmediate(this);
            instance = this;
        }



        public static void Move(Transform transform, Vector3 position, float T)
        {
            var translator = DifferentMethods.React.ActionPool.Take<DifferentMethods.React.Translator>();
            translator.tx = transform;
            translator.target = position;
            translator.duration = T;
            instance.StartCoroutine(translator);
        }

        public static void Rotate(Transform transform, Quaternion rotation, float T)
        {
            var rotator = DifferentMethods.React.ActionPool.Take<DifferentMethods.React.Rotator>();
            rotator.tx = transform;
            rotator.target = rotation;
            rotator.duration = T;
            instance.StartCoroutine(rotator);
        }

    }
}