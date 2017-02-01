using UnityEngine;

namespace FactoryMethod
{

    public class EnemyFactory 
    {
        // Method that return correct enemy
        public Enemy GetEnemy()
        {
            if (Random.value > 0.5f)
            {
                return new MeleeEnemy();
            }

            else
            {
                return new RangedEnemy();
            }
        }
    }
}