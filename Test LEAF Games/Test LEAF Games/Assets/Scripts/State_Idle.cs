using UnityEngine;
using System.Collections;

public class State_Idle : State
{
    public override void StateUpdate()
    {
        Debug.Log("IDLE STATE");
        GetComponentInParent<Rigidbody>().AddForce
            (this.transform.forward * 100 * Time.fixedDeltaTime, ForceMode.Force);
    }

}
