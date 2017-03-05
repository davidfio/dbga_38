using UnityEngine;
using System.Collections;

public class State_Dodge : State
{
    public override void StateUpdate()
    {
        GetComponentInParent<Rigidbody>().AddForce
            (transform.right * -600 * Time.fixedDeltaTime, ForceMode.Impulse);
        
    }    
}
