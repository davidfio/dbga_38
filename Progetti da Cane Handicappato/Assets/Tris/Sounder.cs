using UnityEngine;
using System.Collections;

public class Sounder : MonoBehaviour {

	void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
