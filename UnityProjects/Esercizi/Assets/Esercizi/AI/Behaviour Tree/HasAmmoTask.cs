using UnityEngine;
using System.Collections;

namespace AI.BehaviourTree
{
    public class HasAmmoTask : Task
    {
        public override bool Run()
        {
            return blackboard.bot.currentAmmo > 0;
        }
    }
}