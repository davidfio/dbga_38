using UnityEngine;
using System.Collections;
using System;

namespace AI.DecisionTree
{
    public class DTFIdleActionNode : DTActionNode
    {
        public Movement botMovement;

        public override void MakeDecision()
        {
            botMovement.velocity = Vector3.zero;
        }

    }
}