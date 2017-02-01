using UnityEngine;
using System.Collections;
using System;

namespace AI.DecisionTree
{
    public class DTFleeActionNode : DTActionNode
    {
        public Movement botMovement;
        public Transform playerTR, botTR;

        public override void MakeDecision()
        {
            Vector3 botToPlayerDir = (botTR.position - playerTR.position).normalized;

            botMovement.velocity = botToPlayerDir;
        }
    }
}