using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System;

public class ListenerUE : MonoBehaviour
{
    // The listener creates a UnityEvent
    public UnityEvent myUnityEvent;

    // For delegate need reference to the sender of the Input
    SenderUE refSender;

    // Create a UnityEvent's Property for get and set property of the UnityEvent
    public UnityEvent MyProperty
    {
        get { return myUnityEvent; }
        set { myUnityEvent = value; }
    }

    void Start()
    {
        // Controll if there is a UnityEvent, otherwise initialize it   
        if (myUnityEvent == null)
            myUnityEvent = new UnityEvent();

        // Add methods with no parameters to myUnityEvent
        myUnityEvent.AddListener(SpawnCube);
        myUnityEvent.AddListener(Logger);

        // Assign MethodCalledByDelegate to deleghino
        refSender = FindObjectOfType<SenderUE>();
        refSender.deleghino = MethodCalledByDelegate;
    }

    private void Logger()
    {
        Debug.Log("First Method Spawn Cube, This Second Method Debug Something");
    }

    private void SpawnCube()
    {
        foreach (var meshChild in this.GetComponentsInChildren<MeshRenderer>())
            meshChild.enabled = true;
    }

    private void MethodCalledByDelegate(bool _value, string _message)
    {
        Debug.Log(_value + " " + _message);
    }
}
