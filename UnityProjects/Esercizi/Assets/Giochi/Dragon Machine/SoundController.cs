using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour {

	void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
