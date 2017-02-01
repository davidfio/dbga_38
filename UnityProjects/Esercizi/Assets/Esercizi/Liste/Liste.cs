using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Liste : MonoBehaviour {

	
	void Start () {

        //Creo una lista dinamica di interi
        List<int> listaInt = new List<int>();

        //Aggiungo un elemento alla lista
        listaInt.Add(5);  //in prima posizione inserisce 5
        listaInt.Add(3);  //in seconda posizione inserisce 3

        //Aggiungo il contenuto di un array alla lista 
        int[] tmpList = new int[3] { 1, 2, 3 };
        listaInt.AddRange(tmpList);

        //Aggiungo un int nella posizione che desidero (gli altri elementi vengono scalati automaticamente)
        listaInt.Insert(2, 7);

        //Rimuovo il valore 7 dalla lista (il primo che trova se dovessero essercene più di uno)
        listaInt.Remove(7);

        //Rimuovo il valore alla posizione 0
        listaInt.RemoveAt(0);

        //Restituisce true se la lista contiene un valore 7
        listaInt.Contains(7);
        
        /*Per ogni elemento della lista, stampa il valore
        Debug.Log("Ecco i valori nella lista: \n");

        foreach(int valore in listaInt)
            Debug.Log(valore);
            */

        //Inverti i valori della lista
        listaInt.Reverse();

        //Dispone i valori della lista in ordine crescente
        listaInt.Sort();

        //Stampiamo il contenuto della lista
        Debug.Log("Ecco i valori nella lista: \n");

        for (int i = 0; i < listaInt.Count; i++)
            Debug.Log(listaInt[i]);

        //Svuota la lista
        listaInt.Clear();
    }
}
