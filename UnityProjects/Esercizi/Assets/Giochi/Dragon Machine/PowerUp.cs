using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

    float r;
    
    public void OnTriggerEnter2D(Collider2D coll)
    {
        Dragon refDragon = FindObjectOfType<Dragon>();
        r = Vector3.Dot(this.transform.up.normalized, refDragon.transform.up.normalized);

        if (coll.gameObject.name == "Dragon" && r > 0.8f)
            refDragon.rb.AddForce(refDragon.transform.up * 10, ForceMode2D.Impulse);
    }
}