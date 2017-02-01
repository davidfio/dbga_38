using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestDict : MonoBehaviour {


	void Start ()
    {
        Dictionary<string, int> banckDict = new Dictionary<string, int>();

        // Popoliamo il dizionario
        banckDict.Add("Ciro", 1000);
        banckDict.Add("Carlo", 10000);
        banckDict["David"] = 10;

        // Retrieval di un valore
        //int davidMoney = banckDict["David"];

        // Check di una chiave
        if (banckDict.ContainsKey("Carlo"))
        {
            Debug.Log("Carlo ha " + banckDict["Carlo"]);
        }

        // Check di un valore
        if (banckDict.ContainsValue(10))
        {
            Debug.Log("Esiste qualcuno che ha 10 dollari");
        }

       
        // Itero su ogni chiave e restituisco chiave + valore
        // ATTENZIONE: l'ordine in un hashtable non è GARANTITO in alcun modo
        foreach (var k in banckDict.Keys)
        {
            Debug.Log("Dict has the key: " + k + "with value " + banckDict[k]);
        }

        // Itero su ogni valore 
        foreach (var v in banckDict.Values)
        {
            Debug.Log("Dict has value " + v);
        }

        // Mi ritorna il paio di K e V
        //foreach (var pair in banckDict)
        //{
            //string k = pair.Key;
            //int v = pair.Value;
        //}



        // Puliamo il dizionario
        banckDict.Clear();

    }

	void Update ()
    {
	
	}
}
