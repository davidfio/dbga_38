﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace FactoryMethod
{
   
    public class Spawner : MonoBehaviour
    {
        List<Enemy> spawnedList = new List<Enemy>();

        void Start()
        {
            EnemyFactory factory = new EnemyFactory();

            // Spawn some enemies
            Enemy e1 = factory.GetEnemy();
            Enemy e2 = factory.GetEnemy();

            spawnedList.Add(e1);
            spawnedList.Add(e2);

            // Make them attack
            foreach (var e in spawnedList)
            {
                e.Attack();
            }

        }

    }
}