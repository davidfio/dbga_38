using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DynamicTitle : MonoBehaviour
{
    Text textUI;
    Button buttonUI;
	
	void Awake ()
    {
        textUI = this.GetComponent<Text>();

        textUI.text = "AWAKEEEEEE";

        InvokeRepeating("ChangeText", 0.2f, 0.2f);
	}
	
	
	void ChangeText ()
    {
        textUI.text = "Ciao " + Random.Range(0, 10);
        textUI.color = new Color(Random.value, Random.value, Random.value);
	}
}
