using UnityEngine;

public class Subscriber {

    public PubSubServer server;

    public void Initialise()
    {
        server.SubscribeToTopic("gameplay", this);
    }

    // Method called when message is received
    public void ReceiveMessage(string s)
    {
        Debug.Log("Subscriber received this message: " + s);
    }
}