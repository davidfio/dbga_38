using UnityEngine;
using System.Collections;

public class State_Attack : State
{
    public GameObject bulletSpawn;
    public float speedShoot;

    public override void StateUpdate()
    {
        for (int i = 0; i < PoolingBullet.bulletPool.Count; i++)
        {
            if (!PoolingBullet.bulletPool[i].gameObject.activeInHierarchy)
            {
                PoolingBullet.bulletPool[i].transform.position = bulletSpawn.transform.position;
                PoolingBullet.bulletPool[i].gameObject.SetActive(true);
                PoolingBullet.bulletPool[i].GetComponent<MeshRenderer>().material.color = Color.blue;
                PoolingBullet.bulletPool[i].fromPlayer = false;
                PoolingBullet.bulletPool[i].GetComponent<Rigidbody>().velocity = 
                    bulletSpawn.transform.forward * speedShoot;
                break;
            }
        }
    }
}