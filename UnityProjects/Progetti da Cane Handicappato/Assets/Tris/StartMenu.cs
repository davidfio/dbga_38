using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

	public void OnMouseUp()
    {
        SceneManager.LoadScene(1);
    }
}
