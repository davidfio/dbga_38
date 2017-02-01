using UnityEngine;
using System;
using System.Collections.Generic;

namespace AI.BehaviourTree
{
    public class WaitTask : Task
    {
        public float period = 1;
        private float t = 0;

        public override bool Run()
        {
            t += Time.deltaTime;
            if (t < period)
            {
                return false;
            }

            t = 0;
            return true;
        }
    }
}