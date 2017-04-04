using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CarControl : MonoBehaviour {

    public Rigidbody carRb;

	void Start ()
    {
        Debug.Log(this.gameObject.name);
	}
	

	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            carRb.AddForce(this.transform.forward * 500 * Time.deltaTime, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.S))
        {
            carRb.AddForce(this.transform.forward * -500 * Time.deltaTime, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, -50 * Time.deltaTime, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, 50 * Time.deltaTime, 0, Space.Self);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
        }
    }
}
