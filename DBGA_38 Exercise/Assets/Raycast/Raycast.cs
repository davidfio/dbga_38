using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour
{
	private void Update ()
    {
        if (Input.GetMouseButton(0))
        {
            // It's a the hitted game object
            RaycastHit hit;
            // Cast a ray from the maain camera to the mouse position by ScreenPointToRay
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //Debug.Log("Ray's origin is: " + ray.origin + " and the direciton is: " + ray.direction);

            // If Ray hit something, disable its collider, color of green and debug its name
            if (Physics.Raycast(ray, out hit))
            {
                Debug.DrawLine(ray.origin, hit.point, Color.red, 5f);
                if (hit.collider != null)
                {
                    hit.collider.enabled = false;
                    hit.transform.GetComponent<MeshRenderer>().material.color = Color.green;
                    Debug.Log("You have hit: " + hit.transform.name);
                }
            }
        }
	}
}
