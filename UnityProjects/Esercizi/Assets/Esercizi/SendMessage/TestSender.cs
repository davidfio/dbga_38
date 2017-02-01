using UnityEngine;
using System.Collections;

public class TestSender : MonoBehaviour {

    public GameObject targetGO;

	void Start ()
    {
        // manda un messaggio al GO selezionato
        //targetGO.SendMessage("DoStuff", SendMessageOptions.DontRequireReceiver);

        targetGO.BroadcastMessage("DoStuff", SendMessageOptions.DontRequireReceiver);
    }
}
