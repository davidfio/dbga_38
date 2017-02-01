using UnityEngine;
using System.Collections;

public class MovementCamera : MonoBehaviour
{
    [System.NonSerialized]
    private float dz;

    private void Update ()
    {
        dz = Input.GetAxis("Vertical");

        this.transform.Translate(0, 0, dz, Space.Self);
	}
}
