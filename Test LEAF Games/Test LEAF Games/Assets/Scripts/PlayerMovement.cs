using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 playerPos, mousePos, fixPos;
    private Rigidbody rb;

    private float mouseAngle, dash = 400;
    public float speed;

	private void Awake ()
    {
        rb = this.GetComponent<Rigidbody>();
	}
	
	private void Update ()
    {
        fixPos = new Vector3(this.transform.position.x, 0, this.transform.position.z);
        this.transform.position = fixPos;

        // Take and adjust the positions of mouse and player
        playerPos = Camera.main.WorldToScreenPoint(this.transform.position);
        mousePos = Input.mousePosition;
        mousePos.x -= playerPos.x;
        mousePos.y -= playerPos.y;
        mousePos.Normalize();
        
        // Calculate angle created by mouse for player's rotation 
        mouseAngle = Mathf.Atan2(-mousePos.y, mousePos.x) * Mathf.Rad2Deg;

        rb.MoveRotation(Quaternion.Euler(new Vector3(0, mouseAngle - 270, 0)));

        // Using WASD add a physic continuous force for the player's movement
        // I use fixedDeltaTime in Update because command are more responsive, that's incorrect i know
        if (Input.GetKeyDown(KeyCode.LeftShift))
            rb.AddForce(transform.forward * dash * Time.fixedDeltaTime, ForceMode.Impulse);

        if (Input.GetKey(KeyCode.W))
            rb.AddForce(transform.forward * speed * Time.fixedDeltaTime, ForceMode.Force);

        if (Input.GetKey(KeyCode.S))
            rb.AddForce(transform.forward * -speed * Time.fixedDeltaTime, ForceMode.Force);

        if (Input.GetKey(KeyCode.A))
            rb.AddForce(transform.right * -speed * Time.fixedDeltaTime, ForceMode.Force);

        if (Input.GetKey(KeyCode.D))
            rb.AddForce(transform.right * speed * Time.fixedDeltaTime, ForceMode.Force);
    }
}
