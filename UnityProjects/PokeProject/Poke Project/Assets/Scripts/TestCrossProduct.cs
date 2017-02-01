using UnityEngine;
using System.Collections;

public class TestCrossProduct : MonoBehaviour {

    public Transform targetTransform;
	
	void Update ()
    {   
        // Guardiamo verso il target
        this.transform.LookAt(targetTransform);

        // Mi muovo lungo right
        //transform.position += transform.right * 5 * Time.deltaTime;

        // Calcolo la direzione "right"
        Vector3 myRight;
        myRight = Vector3.Cross(transform.forward, Vector3.up); // per cambiare il senso della rotazione basta invertire up con forward
        transform.position += myRight * 15 * Time.deltaTime;
	}
}
