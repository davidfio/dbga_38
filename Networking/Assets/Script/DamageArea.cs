using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class DamageArea : NetworkBehaviour
{
    public GameObject psGo;
    public BoxCollider boxColl;
    public MeshRenderer mr;

    void OnTriggerEnter(Collider coll)
    {
        if (!isServer)
            return;
        PlayerState ps = coll.gameObject.GetComponent<PlayerState>();
        if (ps!= null)
        {
            ps.TakeDamage(10);
        }
    }

    public override void OnStartServer()
    {
        // We only need the logic part
        Destroy(psGo);
    }

    public override void OnStartClient()
    {
        // We only keep the particle system
        Destroy(boxColl);
        Destroy(mr);
    }

	void Start ()
    {
	
	}
	
	void Update ()
    {
	
	}
}
