using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerDragon : MonoBehaviour
{

    public Text timeDragon;
    public Text playerTime;
    public float lapTime;
    public float bestTime;

    void Update()
    {
        lapTime += Time.deltaTime;
        timeDragon.text = "Tempo: " + lapTime.ToString("000.00");
        playerTime.text = "Giro: " + bestTime.ToString("000.00");
    }
}
