using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AI.BehaviourTree
{
    public class MoveToAmmoTask : Task
    {
        public override bool Run()
        {
            Ammo[] ammos = GameObject.FindObjectsOfType<Ammo>();

            // Find the closest ammo
            float minDistance = Mathf.Infinity;
            Ammo closestAmmo = null;

            foreach (Ammo a in ammos)
            {
                float aDistance = (a.transform.position - blackboard.bot.transform.position).sqrMagnitude;
                if (aDistance < minDistance)
                {
                    minDistance = aDistance;
                    closestAmmo = a;
                }
            }

            Vector3 moveDirections = (closestAmmo.transform.position - blackboard.bot.transform.position).normalized;
            blackboard.botMovement.velocity = moveDirections;
            return true;
        }

    }
}