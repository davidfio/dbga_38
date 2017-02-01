using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace ObjectPool
{

    public class ObjectPool
    {
        // Objects in the pool
        List<Bullet> bullets;

        public GameObject bulletPrefab;

        // Initialise the object pool Max bullets
        public void Initialise(int max)
        {
            bullets = new List<Bullet>();
            for (int i = 0; i < max; i++)
            {
                var go = GameObject.Instantiate(bulletPrefab) as GameObject;
                go.SetActive(false);
                bullets.Add(go.GetComponent<Bullet>());
            }
        }

        // Returns an available object
        public Bullet GetNewObject()
        {
            // Check we have bullets available
            if (bullets.Count == 0)
            {
                Debug.LogWarning("Reached max bullets!");
                return null;
            }

            Bullet b = bullets[0];
            bullets.RemoveAt(0);

            b.gameObject.SetActive(true);

            return b;
        }

        public void Release(Bullet bullet)
        {
            bullets.Add(bullet);
            bullet.gameObject.SetActive(false);
        }

    }
}