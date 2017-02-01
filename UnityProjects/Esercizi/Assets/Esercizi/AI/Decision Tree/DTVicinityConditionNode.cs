using UnityEngine;
using System.Collections;
using System;

namespace AI.DecisionTree
{
    public class DTVicinityConditionNode : DTConditionNode
    {
        public Transform playerTR, botTR;

        public float threshold = 3f;

        public override bool CheckCondition()
        {
            float distance = Vector3.Distance(playerTR.position, botTR.position);
            bool conditionTrue = distance < threshold;
            return conditionTrue;
        }
    }
}