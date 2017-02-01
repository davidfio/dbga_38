using UnityEngine;
using System.Collections;

namespace AI.BehaviourTree
{
    public class NotTask : Task
    {
        public override bool Run()
        {
            return !children[0].Run();
        }

    }
}