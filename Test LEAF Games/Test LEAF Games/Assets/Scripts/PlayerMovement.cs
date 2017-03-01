using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 playerPos, mousePos;
    private Rigidbody rb;

    private float mouseAngle;
    public float speed;

	private void Awake ()
    {
        rb = this.GetComponent<Rigidbody>();
	}
	
	private void Update ()
    {
        // Take and adjust the positions of mouse and player
        playerPos = Camera.main.WorldToScreenPoint(this.transform.position);
        mousePos = Input.mousePosition;
        mousePos.x -= playerPos.x;
        mousePos.y -= playerPos.y;
        mousePos.Normalize();
        
        // Calculate angle created by mouse for player's rotation 
        mouseAngle = Mathf.Atan2(-mousePos.y, mousePos.x) * Mathf.Rad2Deg;
    }

    // Using WASD add a physic continuous force for the player's movement
    private void FixedUpdate()
    {
        rb.MoveRotation(Quaternion.Euler(new Vector3(0, mouseAngle - 270, 0)));

        if (Input.GetKey(KeyCode.W))
            rb.AddForce(transform.forward * speed * Time.fixedDeltaTime, ForceMode.Force);

        if (Input.GetKey(KeyCode.S))
            rb.AddForce(transform.forward * -speed * Time.fixedDeltaTime, ForceMode.Force);

        if (Input.GetKey(KeyCode.A))
            rb.AddForce(transform.right * -speed * Time.fixedDeltaTime, ForceMode.Force);

        if (Input.GetKey(KeyCode.D))
            rb.AddForce(transform.right * speed * Time.fixedDeltaTime, ForceMode.Force);

        if (Input.GetKeyDown(KeyCode.LeftShift))
            rb.AddForce(transform.forward * 600 * Time.fixedDeltaTime, ForceMode.Impulse);
    }
}
