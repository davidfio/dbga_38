using UnityEngine;
using System.Collections;

public class TestRuntimeMaterial : MonoBehaviour {
	
	void Update () {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material mat = mr.material;
        mat.SetColor("_Color",
            Color.HSVToRGB(Mathf.Repeat(Time.time*2,1), 1, 1));
	}
}
