using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PoolingBullet : MonoBehaviour
{
    public static List<Bullet> bulletPool;
    public Bullet bulletGO;

    private byte pooledBullet = 40;

    private void Awake()
    {
        bulletPool = new List<Bullet>();

        // Creates bullets and stock them into the bulletPool
        for (int i = 0; i < pooledBullet; i++)
        {
            Bullet bulletCreate = Instantiate(bulletGO);
            bulletCreate.name = "Bullet";
            bulletCreate.fromPlayer = false;
            bulletCreate.gameObject.SetActive(false);
            bulletPool.Add(bulletCreate);
        }
    }
}
