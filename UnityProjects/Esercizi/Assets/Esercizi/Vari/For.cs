using UnityEngine;
using System.Collections;

public class For : MonoBehaviour { 

    public int valore = 10; 

	// Sommatoria fino a N
	void Start ()
    {
        int somma = 0;
	    for(int i=0; i<valore; i++)
        {
            somma += i;
        }
        Debug.Log(somma);
	}
}