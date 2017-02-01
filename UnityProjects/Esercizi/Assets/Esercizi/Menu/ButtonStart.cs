using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour
{

    public void GoToNextLevel()
    {
        SceneManager.LoadScene("Game");
    }

    public void CatchToggle(bool on)
    {
        Debug.Log("TOGGLE IS " + on);
    }

    public void CatchSlider(float v)
    {
        Debug.Log("Slider is " + v);
    }
}
