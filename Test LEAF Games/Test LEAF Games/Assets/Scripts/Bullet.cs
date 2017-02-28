using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public bool fromPlayer;

    private void OnEnable()
    {
        Invoke("DisableBullet", 1f);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void DisableBullet()
    {
        this.gameObject.SetActive(false);
        fromPlayer = false;
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "Player" && !fromPlayer) 
        {
            this.gameObject.SetActive(false);
            Destroy(coll.gameObject);
        }

        else if (coll.gameObject.name == "Enemy" && fromPlayer)
        {
            this.gameObject.SetActive(false);
            Destroy(coll.gameObject);
        }
    }
}
