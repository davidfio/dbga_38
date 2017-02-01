using UnityEngine;
using System.Collections;

public class Percent : MonoBehaviour
{
    
	void Start ()
    {
        Dice dado = new Dice();
        dado.SetFaces(100);
        int risultato = dado.Throw();

        if (risultato < 50)
            Debug.Log("Ho tirato un da 100 facce. E' uscito: " + risultato + "\nN<50");
        else if (risultato > 50)
            Debug.Log("Ho tirato un da 100 facce. E' uscito: " + risultato + "\nN>50");
        else
            Debug.Log("Ho tirato un da 100 facce. E' uscito: " + risultato + "\nN=50");
    }
}