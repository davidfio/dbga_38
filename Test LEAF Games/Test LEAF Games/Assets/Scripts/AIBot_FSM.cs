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
        StartCoroutine(UpdateCO());
    }
	
	void Update ()
    {
        distance = (byte)Vector3.Distance(mainPlayer.transform.position, this.transform.position);
        LookThePlayer();

        if (distance < threshold)
        {
            sm.HandleInput(InputState.PlayerClose);
        }

        else
        {
            sm.HandleInput(InputState.PlayerNotClose);
            sm.StateUpdate();
        }

        //sm.StateUpdate();
    }

    private void LookThePlayer()
    {
        this.transform.LookAt(mainPlayer.transform.position);
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.name == "Bullet")
        {
            sm.HandleInput(InputState.BulletClose);
            sm.StateUpdate();
            sm.HandleInput(InputState.PlayerClose);
            sm.StateUpdate();
        }
    }

    private IEnumerator UpdateCO()
    {
        while (true)
        {
            sm.StateUpdate();
            Debug.Log("Eseguo lo StateUpdate()");
            yield return new WaitForSeconds(1f);
        }
        
    }
}
