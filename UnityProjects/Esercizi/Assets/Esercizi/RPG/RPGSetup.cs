using UnityEngine;
using System.Collections;

public class RPGSetup : MonoBehaviour
{

	void Start ()
    {
        RPG p1, p2;
        p1 = new RPG();
        p2 = new RPG();
        //int destrezzaRandom = Random.Range(0, 100);
        p1.Initialize(Random.Range(10, 20), 100, Random.Range(0, 100));
        p2.Initialize(Random.Range(10, 20), 100, Random.Range(0, 100));
        Debug.Log("VITA: " + p1.GetHealth() + " vs " + p2.GetHealth());

        while (!p1.CheckHealth() && !p2.CheckHealth())
        {
            Debug.Log("VITA: " + p1.GetHealth() + " vs " + p2.GetHealth());
            p1.Hit(p2.GetStrenght());
            p2.Hit(p1.GetStrenght());
        }

        if (p1.CheckHealth())
            Debug.Log("Giocatore 2 vince!");
        else if (p2.CheckHealth())
            Debug.Log("Giocatore 1 vince!");
    }
}