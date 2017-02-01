using UnityEngine;
using System.Collections;

//Gioco che indovina un numero
public class IndovinaWhile : MonoBehaviour
{ 
    public int numeroDaIndovinare = 15;

    void Start()
    {
        int numeroCheStoProvando = 0;
        bool numeroTrovato = false;
        while (!numeroTrovato)
        {
            numeroCheStoProvando++;
            numeroTrovato = (numeroCheStoProvando == numeroDaIndovinare);
            Debug.Log("Sto provando con il numero " + numeroCheStoProvando);
        }
        Debug.Log("Stai pensando al numero " + numeroDaIndovinare);
    }
}