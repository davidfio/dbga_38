using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletController : MonoBehaviour
{   
    // Number of initial bullet pooled in the List
    private byte pooledBullet = 25;
    List<GameObject> bulletPool;

    public GameObject bulletGO, bulletSpawn;

    private void Start ()
    {
        bulletPool = new List<GameObject>();

        // Create 25 bullets and stock the bullet into the bulletPool
        for (int i = 0; i < pooledBullet; i++)
        {
            GameObject bulletCreate = Instantiate(bulletGO);
            bulletCreate.SetActive(false);
            bulletPool.Add(bulletCreate);
        }
	}
	
	private void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }
	}

    private void FireBullet()
    {
        for (int i = 0; i < bulletPool.Count; i++)
        {
            if (!bulletPool[i].activeInHierarchy)
            {
                bulletPool[i].SetActive(true);
                bulletPool[i].transform.position = bulletSpawn.transform.position;

                bulletPool[i].GetComponent<Rigidbody>().AddForce(bulletSpawn.transform.forward * 10, ForceMode.Impulse);
                break;
            }
        }
    }    
}
