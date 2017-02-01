using UnityEngine;
using System.Collections;

namespace AI.FSM
{
    public class AIBot_FSM : MonoBehaviour
    {
        private StateMachine sm;

        void Start()
        {
            // Let's initialise the SM
            sm = new StateMachine();
            sm.stateFlee = GetComponentInChildren<State_Flee>();
            sm.stateIdle = GetComponentInChildren<State_Idle>();
            sm.stateSearch = GetComponentInChildren<State_Search>();
            sm.stateFollow = GetComponentInChildren<State_Follow>();

            // Set the initial state
            sm.initialState = sm.stateIdle;
            sm.StartMachine();

            // Create the transitions too
            sm.CreateTransition();

            InvokeRepeating("SendTimeoutInput", 5f, 5f);
        }

        private void SendTimeoutInput()
        {
            sm.HandleInput(Input.Timeout);
        }

        public Transform playerTr;
        public float threshold = 5f;

        void Update()
        {
            // Get inputs
            float distance = Vector3.Distance(playerTr.position, this.transform.position);

            if (distance< threshold)
                sm.HandleInput(Input.PlayerClose);
            else
                sm.HandleInput(Input.PlayerNotClose);

            if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
            {
                sm.HandleInput(Input.Superfollow);
            }
            // Attribute each frame, we ask the FSM to do whattever its current state wants to do
            sm.StateUpdate();
        }
    }
}