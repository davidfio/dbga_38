using UnityEngine;
using System.Collections;

public class AIBot_FSM : MonoBehaviour
{
    public GameObject mainPlayer;
    private StateMachine sm;
    private Vector3 fixPos;
    private byte distance;
    private byte threshold = 10;

    private void Start()
    {
        sm = new StateMachine();
        sm.stateIdle = GetComponentInChildren<State_Idle>();
        sm.stateAttack = GetComponentInChildren<State_Attack>();
        sm.stateDodge = GetComponentInChildren<State_Dodge>();

        sm.initialState = sm.stateIdle;
        sm.StartMachine();
        sm.CreateTransition();
        StartCoroutine(UpdateAttackCO());
        StartCoroutine(UpdateCO());
    }

#region Methods Declaration

    private void LookThePlayer()
    {
        this.transform.LookAt(mainPlayer.transform.position);
    }

    // IA's dodge pattern
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

    // Fire rate of IA's attack 
    private IEnumerator UpdateAttackCO()
    {
        while (true)
        {
            sm.StateUpdate();
            yield return new WaitForSeconds(1f);
        }
        
    }

    // IA's update
    private IEnumerator UpdateCO()
    {
        while (mainPlayer.gameObject != null)
        {
            fixPos = new Vector3(this.transform.position.x, 0, this.transform.position.z);
            this.transform.position = fixPos;
            LookThePlayer();

            distance = (byte)Vector3.Distance(mainPlayer.transform.position, this.transform.position);

            // Go into Attack State
            if (distance < threshold)
                sm.HandleInput(InputState.PlayerClose);
            // Otherwise go in Idle
            else
            {
                sm.HandleInput(InputState.PlayerNotClose);
                sm.StateUpdate();
            }
            yield return null;
        }
        yield break;
    }
#endregion
}
