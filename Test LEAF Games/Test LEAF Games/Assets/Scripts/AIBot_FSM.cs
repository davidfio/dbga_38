using UnityEngine;
using System.Collections;

public class AIBot_FSM : MonoBehaviour
{
    public GameObject mainPlayer;
    private StateMachine sm;
    private byte distance;
    private byte threshold = 10;

    private void Start ()
    {
        sm = new StateMachine();
        sm.stateIdle = GetComponentInChildren<State_Idle>();
        sm.stateAttack = GetComponentInChildren<State_Attack>();
        sm.stateDodge = GetComponentInChildren<State_Dodge>();

        sm.initialState = sm.stateIdle;
        sm.StartMachine();
        sm.CreateTransition();
    }
	
	void Update ()
    {
         distance = (byte)Vector3.Distance(mainPlayer.transform.position, this.transform.position);

        if (distance < threshold)
        {
            sm.HandleInput(InputState.PlayerClose);
        }

        LookThePlayer();
        sm.StateUpdate();
	}

    private void LookThePlayer()
    {
        this.transform.LookAt(mainPlayer.transform.position);
    }
}
