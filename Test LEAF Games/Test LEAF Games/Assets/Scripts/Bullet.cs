using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public bool fromPlayer;
    private GameController refGC;

    private void Awake()
    {
        refGC = FindObjectOfType<GameController>();
    }

#region Methods Declaration

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
        GetComponent<MeshRenderer>().material.color = Color.white;
        fromPlayer = false;
    }

    // Destroy the Player, the enemies and the others bullets
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "Player" && !fromPlayer) 
        {
            DisableBullet();
            Destroy(coll.gameObject);
            refGC.myUnityEvent.Invoke();
        }

        else if (coll.gameObject.name == "Enemy" && fromPlayer)
        {
            DisableBullet();
            Destroy(coll.gameObject);
        }

        else if (coll.gameObject.name == "Bullet")
        {
            DisableBullet();
        }
    }
#endregion
}
