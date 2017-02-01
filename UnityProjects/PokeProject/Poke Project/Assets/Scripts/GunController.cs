using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {

    public GameObject bulletToSpawn;
    public byte bullet = 150;
    [Range(50, 100)]
    public byte bulletSpeed = 80;
    public AudioSource soundBulletAS;

    UI refUI;

	void Start ()
    {
        refUI = FindObjectOfType<UI>();
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) // Quando premo tasto sx mouse sparo, abbasso contatore bullet, fai suono e rinculo arma
        {
            GameObject bulletGo = Instantiate(bulletToSpawn);
            bulletGo.transform.position = this.transform.position;
            bulletGo.GetComponent<Rigidbody>().AddForce(transform.up * -bulletSpeed, ForceMode.Impulse);
            soundBulletAS.Play();
            bullet--;
            refUI.BulletCount();
            StartCoroutine("MovementGun");

            if(bullet <= 0)
            {
                bullet = 150;
            }

        }
	}

    IEnumerator MovementGun() // Per il movimento dell'arma quando spara
    {
        this.transform.position += new Vector3(0, 0, 0.1f);
        yield return new WaitForSeconds(0.05f);
        this.transform.position -= new Vector3(0, 0, 0.1f);

    }
}
