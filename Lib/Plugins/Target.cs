using UnityEngine;
using System.Collections;

using System.Collections.Generic;


namespace DifferentMethods.React.Components
{
    public class Target : MonoBehaviour
    {

        [System.NonSerialized]
        public GameObject activeTarget;
        List<GameObject> targets = new List<GameObject>();


        void OnDrawGizmosSelected()
        {
            if (activeTarget != null)
            {
                Gizmos.color = Color.yellow;
                Gizmos.DrawWireSphere(activeTarget.transform.position, 5);
                Gizmos.DrawLine(transform.position, activeTarget.transform.position);
            }
        }

        public bool CanSeeTarget(float range)
        {
            RaycastHit hit;
            var ray = new Ray(transform.position, activeTarget.transform.position - transform.position);
            if (Physics.Raycast(ray, out hit, range))
            {
                if (hit.collider.gameObject == activeTarget)
                    return true;
            }
            return false;
        }

        public bool FindTargets(LayerMask layer, float range)
        {
            var hits = Physics.OverlapSphere(transform.position, range, layer.value);
            targets.Clear();
            if (hits.Length > 0)
            {
                for (int i = 0; i < hits.Length; i++)
                {
                    var c = hits[i];
                    if (c.gameObject != gameObject)
                    {
                        targets.Add(c.gameObject);
                    }
                }
            }
            return targets.Count > 0;
        }

        public bool ChooseFurthestTarget()
        {
            var distance = 0f;
            var position = transform.position;
            activeTarget = null;
            for (int i = 0; i < targets.Count; i++)
            {
                var target = targets[i];
                var targetDistance = (target.transform.position - position).sqrMagnitude;
                if (targetDistance > distance)
                {
                    distance = targetDistance;
                    activeTarget = target;
                }
            }
            return activeTarget != null;
        }

        public bool ChooseClosestTarget()
        {
            var distance = float.MaxValue;
            var position = transform.position;
            activeTarget = null;
            for (int i = 0; i < targets.Count; i++)
            {
                var target = targets[i];
                if (target == null)
                    continue;
                var targetDistance = (target.transform.position - position).sqrMagnitude;
                if (targetDistance < distance)
                {
                    distance = targetDistance;
                    activeTarget = target;
                }
            }
            return activeTarget != null;
        }

        public bool ChooseRandomTarget()
        {
            activeTarget = null;
            if (targets.Count == 0)
                return false;
            activeTarget = targets[Random.Range(0, targets.Count)];
            return true;
        }

        public bool TargetIsCloserThan(float distance)
        {
            if (activeTarget == null)
                return false;
            return (activeTarget.transform.position - transform.position).sqrMagnitude <= (distance * distance);
        }

        public bool TargetIsFurtherThan(float distance)
        {
            if (activeTarget == null)
                return false;
            return (activeTarget.transform.position - transform.position).sqrMagnitude >= (distance * distance);
        }

        public bool HaveTarget()
        {
            return activeTarget != null;
        }



    }
}