using UnityEngine;
using System.Collections;

public class PlayerShooter : MonoBehaviour
{   
    // Number of initial bullet pooled in the List   
    public byte speedShoot = 20;

    public GameObject bulletSpawn;

    private void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }
	}

    private void FireBullet()
    {
        for (int i = 0; i < PoolingBullet.bulletPool.Count; i++)
        {
            if (!PoolingBullet.bulletPool[i].gameObject.activeInHierarchy)
            {
                PoolingBullet.bulletPool[i].fromPlayer = true;
                PoolingBullet.bulletPool[i].transform.position = bulletSpawn.transform.position;
                PoolingBullet.bulletPool[i].gameObject.SetActive(true);
                PoolingBullet.bulletPool[i].GetComponent<Rigidbody>().velocity = bulletSpawn.transform.forward * speedShoot;
                break;
            }
        }
    }    
}
