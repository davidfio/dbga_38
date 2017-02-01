using UnityEngine;
using System.Collections;

public class TestBottle : MonoBehaviour {

    void Start ()
    {
        Bottle a = new Bottle(5);
        Bottle b = new Bottle(10);
        Bottle c = a + b;
        Debug.Log(c);
	}
	

	void Update ()
    {
	
	}
}
