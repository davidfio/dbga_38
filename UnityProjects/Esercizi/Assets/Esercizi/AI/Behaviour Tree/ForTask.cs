using UnityEngine;
using System.Collections;

namespace AI.BehaviourTree
{
    public class ForTask : Task
    {
        public int nRepeat = 1;
        public override bool Run()
        {
            for (int i = 0; i < nRepeat; i++)
            {
                if (!children[0].Run()) return false;
            }
            return true;
        }

    }
}