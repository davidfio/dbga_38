using UnityEngine;
using System.Collections;

public class DiceTester : MonoBehaviour
{

	void Start ()
    {
        // Definiamo una variabile di tipo Dice
        Dice dado;

        // Creiamo un oggetto di tipo Dice e lo mettiamo nella variabile d, deve essere quindi inizializzato all'interno della memoria
        dado = new Dice();

        //Settiamo il numero di facce (adesso è possibile perchè abbiamo un riferimento)
        dado.SetFaces(6);

        // Tiriamo il dado per ottenere un numero casuale 
        int result = dado.Throw();

        // Logghiamo il risultato
        Debug.Log("Ho lanciato un dado ed è uscito: " + result);

        // Lanciamo 10 dadi e sommiamo il risultato
        int somma = 0;
        
        /* 
           1) Crea un nuovo dado 
           2) Imposta le facce 
           3) Crea una variabile di interi 
           4) Richiama la funzione della scelta random del numero del dado 
           5) Somma il numero random scelto alla variabile somma. 
           6) Tutto questo viene ripetuto per 10 volte.
        */

        for (int i = 0; i < 10; i++)
        {
            Dice dadi = new Dice();
            dadi.SetFaces(6);
            int resultDice = dadi.Throw();
            somma += resultDice;
        }
        Debug.Log("Ho tirato 10 dadi ed ho sommato 0. Il risultato è: " + somma);
	}
}