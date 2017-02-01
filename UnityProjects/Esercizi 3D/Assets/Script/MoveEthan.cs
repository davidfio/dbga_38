using UnityEngine;
using System.Collections;

public class MoveEthan : MonoBehaviour {

    public float maxSpeed = 5f;
    public float acceleration = 5f;
    public float deceleration = 5f;
    private float currentSpeed = 0f;

    [Range(0f, 1f)]
    public float drunkness = 0f;

    private Animator animEthan;

	void Start ()
    {
        animEthan = GetComponent<Animator>();
	}
	

	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
            currentSpeed += acceleration * Time.deltaTime;

        else
            currentSpeed -= deceleration * Time.deltaTime;

        currentSpeed = Mathf.Clamp(currentSpeed, 0, maxSpeed);

        animEthan.SetFloat("Speed", currentSpeed / maxSpeed);
        animEthan.SetFloat("Drunkness", drunkness);
	}
}