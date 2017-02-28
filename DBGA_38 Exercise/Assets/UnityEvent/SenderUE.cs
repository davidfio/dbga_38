using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System;

public class SenderUE : MonoBehaviour
{
    // Create a standard delegate with bool and string
    public Action<bool, string> deleghino;
    
    /*
    // For UnityEvent i need a reference to the ListenerUI      
    ListenerUE refListenerUE;


    private void Awake()
    {
        refListenerUE = FindObjectOfType<ListenerUE>();
    }

	private void OnTriggerEnter(Collider _other)
    {
        if (_other.gameObject.name == "Player")
            // With or without a Property, i can invoke all the method add to the UnityEvent 
            //refListenerUE.myUnityEvent.Invoke();
            refListenerUE.MyProperty.Invoke();
    }
    */
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            // Throw and set parameters of Delegate
            deleghino(true, "Debug Of My First Delegate, That Take As Argument A Bool And This String");    
    }
}
