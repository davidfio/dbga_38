using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
namespace TestSortedList2
{

    public class Enemy : IComparable<Enemy> //, IComparable
    {

        // IComparable non tipizzato
        /*public int CompareTo(object obj)
        {
            if (obj is Enemy)
            {
                Enemy obj_enemy = (Enemy)obj;
                return health.CompareTo(obj_enemy.health);
            }
            else
            {
                return 0; // TODO: add an error here
            }   
        }*/

        public int level, health, strength;

        public Enemy(int _level, int _health, int _strength)
        {
            this.level = _level;
            this.health = _health;
            this.strength = _strength;
        }

        // IComparable<Enemy> 
        public int CompareTo(Enemy other)
        {
            return health.CompareTo(other.health);
        }

        public override string ToString()
        {
            return "(L" +level+ ", H" +health+ ", S" +strength+ ")";
        }
    }

    public class EnemyComparer : IComparer<Enemy>
    {
        public int Compare(Enemy e1, Enemy e2)
        {
            int equal_Value = e1.level.CompareTo(e2.level); // Ritorna 0 se ugauli, < 0 se il primo è più piccolo, ecc

            if (equal_Value == 0)
            {
                equal_Value = e1.health.CompareTo(e2.health); // Se il livello è uguale, controlla invece la vita

                if (equal_Value == 0)
                    equal_Value = e1.strength.CompareTo(e2.strength); // Se la vita è uguale, controlla invece la forza
            }

            return equal_Value;
        }
    }

    public class TestSortedList2 : MonoBehaviour
    {

        void Start()
        {
            SortedList<Enemy, string> enemyDescriptionsSortedList = new SortedList<Enemy, string>();

            Enemy e1 = new Enemy(1, 10, 3);
            Enemy e2 = new Enemy(2, 5, 5);
            Enemy e3 = new Enemy(3, 2, 4);

            enemyDescriptionsSortedList.Add(e3, "Nemico 3");
            enemyDescriptionsSortedList.Add(e2, "Nemico 2");
            enemyDescriptionsSortedList.Add(e1, "Nemico 1");

            /*foreach (var pair in enemyDescriptionsSortedList)
            {
                Debug.Log(pair.Key + ": " + pair.Value);
            }*/

            // Ordiniamo una lista di nemici secondo un qulahc criterio
            // Ordine sarà: Livello >> Vita >> Forza
            List<Enemy> enemyList = new List<Enemy>();
            enemyList.Add(new Enemy(1, 1, 1));
            enemyList.Add(new Enemy(3, 3, 3));
            enemyList.Add(new Enemy(1, 2, 2));
            enemyList.Add(new Enemy(2, 4, 2));
            enemyList.Add(new Enemy(2, 2, 2));
            enemyList.Add(new Enemy(1, 2, 1));
            enemyList.Add(new Enemy(2, 2, 4));


            EnemyComparer comparer = new EnemyComparer();
            enemyList.Sort(comparer);

            foreach (var e in enemyList)
            {
                Debug.Log(e);
            }
        }
    }
}
