using UnityEngine;
using System.Collections;

public class FPSController : MonoBehaviour {

    float mouseY;
    [Range(50,255)]
    public byte sensibilityMouse = 100;


	void Start ()
    {
        
	}
	

	void Update ()
    {
        //Cursor.lockState = CursorLockMode.Locked;

        mouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(transform.right, mouseY * -sensibilityMouse * Time.deltaTime, Space.World);

    }
}
