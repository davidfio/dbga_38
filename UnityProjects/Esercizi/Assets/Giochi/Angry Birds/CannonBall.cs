using UnityEngine;
using System.Collections;

public class CannonBall : MonoBehaviour {

    public GameObject ballToSpawn;
    [Range(0,50)]
    public int strengthBall;
    //int nPalla = 1;
    
    
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject cannonballGo = Instantiate(ballToSpawn);
            cannonballGo.name = "Palla";
            cannonballGo.transform.position = this.transform.position;
            // Metto in rb la componente RigidBody 2D
            Rigidbody2D rb = cannonballGo.GetComponent<Rigidbody2D>();
            // Applico una forza (un impulso) verso la destra del cannone 
            rb.AddForce(transform.right * strengthBall, ForceMode2D.Impulse);

            AudioSource audioSource = GetComponent<AudioSource>();

            audioSource.Play();
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Cambio la rotazione di 10 premendo Up Arrow
            this.transform.Rotate(new Vector3(0, 0, 50) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            // Cambio rotazione di -10 premendo Down Arrow
            this.transform.Rotate(new Vector3(0, 0, -50) * Time.deltaTime);
        }

    }
}
