using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Dragon : MonoBehaviour {

    public Rigidbody2D rb;
    int accStrength = 10;
    int decStrength = -10;
    public bool isAccelerating, isDecelerating;

    void Update()
    {
        isAccelerating = Input.GetKey(KeyCode.W);
        isDecelerating = Input.GetKey(KeyCode.S);

        if (Input.GetKey(KeyCode.D))
            this.transform.Rotate(new Vector3(0, 0, -100) * Time.deltaTime);
        else if (Input.GetKey(KeyCode.A))
            this.transform.Rotate(new Vector3(0, 0, 100) * Time.deltaTime);
    }

    void FixedUpdate()
    {
        if (isAccelerating)
            rb.AddForce(transform.up * accStrength);
        else if (isDecelerating)
            rb.AddForce(transform.up * decStrength);
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "FinalTrigger")
        {
            GameControllerDragon refGDC = FindObjectOfType<GameControllerDragon>();
            refGDC.bestTime = refGDC.lapTime;
            SceneManager.LoadScene(1);
        }
    }
}
