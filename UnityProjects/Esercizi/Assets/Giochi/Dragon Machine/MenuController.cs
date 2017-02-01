using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public void OnMouseUp()
    {
        SceneManager.LoadScene(1);
    }
}

