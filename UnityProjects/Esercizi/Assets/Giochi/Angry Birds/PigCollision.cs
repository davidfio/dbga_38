using UnityEngine;
using System.Collections;

public class PigCollision : MonoBehaviour {

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Palla" || coll.gameObject.name == "Bad Piggle")
        {
            Destroy(this.gameObject);
            Destroy(coll.gameObject);
        }
    }
}
