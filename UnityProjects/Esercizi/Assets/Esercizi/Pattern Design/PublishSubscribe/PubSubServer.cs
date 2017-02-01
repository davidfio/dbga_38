using System.Collections.Generic;
using UnityEngine;

public class PubSubServer {

    Dictionary<string, List<Subscriber>> subscribersDict = new Dictionary<string, List<Subscriber>>();

    // Subscribe will call this to subscirbe to specific topic
    public void SubscribeToTopic(string topic, Subscriber sub)
    {
        if (!subscribersDict.ContainsKey(topic))
            subscribersDict[topic] = new List<Subscriber>();

        subscribersDict[topic].Add(sub);
    }

    // Publisher will call this to send message about a topic
    public void SendMessage(string s, string topic)
    {
        if (!subscribersDict.ContainsKey(topic))
            return;

        foreach(Subscriber sub in subscribersDict[topic])
            sub.ReceiveMessage(s);
    }
}
