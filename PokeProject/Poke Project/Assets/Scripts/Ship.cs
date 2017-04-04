using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

    UI refUI;
    Movement refMovement;
    GunController refGC;
    FPSController refFPS;


	void Awake ()
    {
        refUI = FindObjectOfType<UI>();
        refMovement = FindObjectOfType<Movement>();
        refGC = FindObjectOfType<GunController>();
        refFPS = FindObjectOfType<FPSController>();
	}
	
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "FirstPersonView")
        {
            refUI.startRaceButton.gameObject.SetActive(true);
            refUI.refuseRace.gameObject.SetActive(true);
            refMovement.enabled = false;
            refGC.enabled = false;
            refFPS.enabled = false;
        }
    }
}
