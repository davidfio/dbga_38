using UnityEngine;
using System.Collections;

public class Sender : MonoBehaviour
{

    // Send message need a reference to the GameObject that has the called method

    Receiver refReceiver;

    private void Awake()
    {
        refReceiver = FindObjectOfType<Receiver>();
    }

	private void OnTriggerEnter(Collider _other)
    {
        if (_other.gameObject.name == "Player")
        {
            // Call method SpawnCube and i pass the string as parameter
            refReceiver.SendMessage("SpawnCube", "A Luca puzza decisamente il culo");
        }
    }
}
