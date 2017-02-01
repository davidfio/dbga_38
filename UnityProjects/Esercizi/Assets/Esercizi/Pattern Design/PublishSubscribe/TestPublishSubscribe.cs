using UnityEngine;
using System.Collections;

public class TestPublishSubscribe : MonoBehaviour {

	void Start ()
    {
        //Initialization
        PubSubServer server = new PubSubServer();

        Subscriber subscriber1 = new Subscriber();
        subscriber1.server = server;
        subscriber1.Initialise(); // subscriber will subscribe to the server

        Publisher publisher1 = new Publisher();
        publisher1.server = server;

        // Use
        publisher1.PublishMessage("Ciao1");
        publisher1.PublishMessage("Ciao2");
	}	
}
