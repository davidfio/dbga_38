using UnityEngine;
using System.Collections;

public class State_Idle : State
{
    public override void StateUpdate()
    {
        GetComponentInParent<Rigidbody>().AddForce
            (this.transform.forward * 200 * Time.deltaTime, ForceMode.Force);
    }
}
