using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GameController : MonoBehaviour
{
    public UnityEvent myUnityEvent;
    public UnityEvent MyProperties
    {
        get { return myUnityEvent; }
        set { myUnityEvent = value; }
    }

    private ParticleSystem pc;
    private PlayerShooter refPS;

	private void Awake ()
    {
        if (myUnityEvent == null)
            myUnityEvent = new UnityEvent();

        pc = GetComponentInChildren<ParticleSystem>();
        refPS = FindObjectOfType<PlayerShooter>();

        Time.timeScale = 0;
	}

#region Methods Declaration
    public void ResetMatch()
    {
        SceneManager.LoadScene(0);
    }

    public void ParticlesPlayer(GameObject player)
    {
        pc.transform.position = player.transform.position;
        pc.Play();
    }

    public void StartMatch()
    {
        Time.timeScale = 1;
        refPS.isFinishTutorial = true;
    }
#endregion
}
