using UnityEngine;
using System.Collections;

namespace AI.BehaviourTree
{
    public class PlayerIsCloseTask : Task
    {
        public float threshold =  4;
        public override bool Run()
        {
            float distance = (blackboard.bot.transform.position - blackboard.player.transform.position).magnitude;
            return distance < threshold;
        }

    }
}