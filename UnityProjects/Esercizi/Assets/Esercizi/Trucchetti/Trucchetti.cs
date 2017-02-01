using UnityEngine;
using System.Collections;



public class Trucchetti : MonoBehaviour {

	void Start ()
    {
        string[] stringArray = new string[5];
        stringArray[0] = "Ciao";
        stringArray[1] = "aaa";
        stringArray[2] = "bbb";
        stringArray[3] = "ccc";
        stringArray[4] = "ddd";

        foreach (string s in stringArray)
        {
            Debug.Log(s);
        }

    }
	

	void Update ()
    {
	
	}
}
