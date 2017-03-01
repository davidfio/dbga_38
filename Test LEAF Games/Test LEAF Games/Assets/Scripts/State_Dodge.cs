using UnityEngine;
using System.Collections;

public class State_Dodge : State
{
    //public Rigidbody rb;
    public override void StateUpdate()
    {
        Debug.Log("DODGE STATE");
        GetComponentInParent<Rigidbody>().AddForce
            (transform.right * -600 * Time.fixedDeltaTime, ForceMode.Impulse);
        
    }    
}
