using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	void Update()
    {
        Invoke("DestroyThis", 5f);
    }

    void DestroyThis()
    {
        Destroy(this.gameObject);
    }


}
