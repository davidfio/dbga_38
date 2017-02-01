using UnityEngine;

public class Publisher {

    public PubSubServer server;

    //The publisher send a message to the server
	public void PublishMessage (string s)
    {
        server.SendMessage(s, "gameplay");
	}
}
