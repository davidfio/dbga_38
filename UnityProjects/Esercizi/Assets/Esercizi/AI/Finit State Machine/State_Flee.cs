using UnityEngine;
using System.Collections;

namespace AI.FSM
{
    public class State_Flee : State
    {
        public Movement botMovement;
        public Transform playerTr, botTr;


        public override void StateUpdate()
        {
            // Flee from player
            Vector3 botPlayerDirection = (botTr.position - playerTr.position).normalized;
            botMovement.velocity = botPlayerDirection;
        }

    }
}