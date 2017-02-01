using UnityEngine;
using System.Collections;

namespace AI.FSM
{
    public class State_Idle : State
    {
        public Movement botMovement;


        public override void StateUpdate()
        {
            // Move randomly around
            botMovement.velocity = Vector3.zero;
        }

    }
}