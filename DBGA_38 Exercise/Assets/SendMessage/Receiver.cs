using UnityEngine;
using System.Collections;

public class Receiver : MonoBehaviour
{
    // Method that receive a message as parameter
    private void SpawnCube(string _message)
    {
        // meshChild is each MeshRenderer of each children of this GameObject
        foreach (var meshChild in this.GetComponentsInChildren<MeshRenderer>())
        {
            // Enable every MeshRenderer
            meshChild.enabled = true;
            Debug.Log("LOL");
        }

        // Debug the lenght of GetComponentsInChildren's array
        Debug.Log(this.GetComponentsInChildren<Transform>().Length);
        Debug.Log(_message);
    }
}
