using UnityEngine;
using System.Collections;

public class TargetMovement : MonoBehaviour
{
    private Vector3 rightDir;
    public bool changeDir;

    void Start ()
    {
        rightDir = new Vector3(Random.Range(2,5), 0, 0);
        StartCoroutine(ChangeBool());
    }
	
	void Update ()
    {
        if (changeDir)
            this.transform.position += rightDir * Time.deltaTime;
        else
            this.transform.position -= rightDir * Time.deltaTime;
    }

    private IEnumerator ChangeBool()
    {
        while (true)
        {
            changeDir = false;
            yield return new WaitForSeconds(Random.Range(0, 3));
            changeDir = true;
            yield return new WaitForSeconds(Random.Range(0, 3));
        }
    }
}
