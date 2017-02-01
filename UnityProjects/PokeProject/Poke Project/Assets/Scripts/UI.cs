using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {

    public Text bullCount, timeCount;
    public Button startRaceButton, refuseRace;
    GunController refGC;
    Movement refMovement;
    FPSController refFPS;

    void Start ()
    {
        refGC = FindObjectOfType<GunController>();
        refMovement = FindObjectOfType<Movement>();
        refFPS = FindObjectOfType<FPSController>();
        BulletCount();
        TimeCounter();
	}

    void Update()
    {
        TimeCounter();
    }
	
   public void BulletCount()
    {
        bullCount.text = refGC.bullet.ToString();
    }

    public void StartRace()
    {
        SceneManager.LoadScene(1);
    }

    public void Negative()
    {
        refMovement.enabled = true;
        refGC.enabled = true;
        refFPS.enabled = true;
        refuseRace.gameObject.SetActive(false);
        startRaceButton.gameObject.SetActive(false);
    }

    void TimeCounter()
    {
        timeCount.text = "Time: " + Time.time.ToString("000.00");
    }
}
