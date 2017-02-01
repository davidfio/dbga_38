using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    byte walk;
    float mouseX;
    public Rigidbody rb;
    FPSController refFPSController;

    void Start ()
    {
        walk = 5;
        refFPSController = FindObjectOfType<FPSController>();
    }
	

	void Update ()
    {
        mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, mouseX * refFPSController.sensibilityMouse * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * walk * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -walk * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * walk * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * -walk * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftShift))
            walk = 10;
        else
            walk = 5;

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 4.5f * Time.deltaTime, ForceMode.Impulse);
        }

    }
}
