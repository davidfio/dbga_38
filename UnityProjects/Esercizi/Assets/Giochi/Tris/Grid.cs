using UnityEngine;
using System.Collections;

namespace Tris
{ 
    public class Grid : MonoBehaviour
    {
        // Definizione di variabili
        public int currentPlayer = 1;
        int[,] grid = new int[3, 3];
        public GameObject cellPrefab; // Qua dentro c'è CellPrefab (la sprite) dalla nostra scena

        // Metodi
        void Start ()
        {
            // Crea 3x3 celle (j=asse x, i=asse y)
            for (int i=0; i < grid.GetLength(0); i++)
            {
                for (int j=0; j < grid.GetLength(1); j++)
                {
                    // Crea una nuova cella
                    GameObject newcell = Instantiate(cellPrefab);
                    newcell.transform.position = new Vector3(j, -i);
                    newcell.name = "Cella " + i + " " + j;
                }
            }
            Destroy(cellPrefab);
	    }
        public void CheckWinner()
        {
            /* Prende tutte le celle, controlla i valori delle celle, se trova tre celle con state 1 o 2 sulla stessa riga, 
            colonna e diagonale allora il giocatore giusto ha vinto */
            Cell[] allCells = FindObjectsOfType<Cell>();

            for (int i = 0; i < allCells.Length; i++)
            {
                Debug.Log("La cella " + i + " è" + allCells[i].name);
            }
            // Controlla la riga in alto
            int result = DidSomeoneWin(allCells[8].state, allCells[7].state, allCells[6].state);
            if (result > 0)
            {
                Debug.Log("Ha vinto il giocatore " + result);
                return; // termina l'esecuzione
            }
            // Controlla la riga al centro
            result = DidSomeoneWin(allCells[5].state, allCells[4].state, allCells[3].state);
            if (result > 0)
            {
                Debug.Log("Ha vinto il giocatore " + result);
                return; // termina l'esecuzione
            }
            // Controlla la riga in basso
            result = DidSomeoneWin(allCells[3].state, allCells[2].state, allCells[1].state);
            if (result > 0)
            {
                Debug.Log("Ha vinto il giocatore " + result);
                return; // termina l'esecuzione
            }
            // Controlla la colonna a sinistra
            result = DidSomeoneWin(allCells[8].state, allCells[5].state, allCells[2].state);
            if (result > 0)
            {
                Debug.Log("Ha vinto il giocatore " + result);
                return; // termina l'esecuzione
            }
            // Controlla la colonna al centro
            result = DidSomeoneWin(allCells[7].state, allCells[4].state, allCells[1].state);
            if (result > 0)
            {
                Debug.Log("Ha vinto il giocatore " + result);
                return; // termina l'esecuzione
            }
            // Controlla la colonna a destra
            result = DidSomeoneWin(allCells[6].state, allCells[3].state, allCells[0].state);
            if (result > 0)
            {
                Debug.Log("Ha vinto il giocatore " + result);
                return; // termina l'esecuzione
            }
            // Controlla la diagonale principale
            result = DidSomeoneWin(allCells[8].state, allCells[4].state, allCells[0].state);
            if (result > 0)
            {
                Debug.Log("Ha vinto il giocatore " + result);
                return; // termina l'esecuzione
            }
            // Controlla l'altra diagonale
            result = DidSomeoneWin(allCells[6].state, allCells[4].state, allCells[2].state);
            if (result > 0)
            {
                Debug.Log("Ha vinto il giocatore " + result);
                return; // termina l'esecuzione
            }
            // Se siamo qua, nessuno finora ha vinto, controlliamo se c'è una parità
            int productForDraw = 1;
            for (int i = 0; i < allCells.Length; i++)
            {
                productForDraw *= allCells[i].state;
            }

            if (productForDraw > 0)
            {
                Debug.Log("Parità!");
            }
        }
        private int DidSomeoneWin(int v1, int v2, int v3)
        {
            int product = v1 * v2 * v3;
            // Se esce 0, parità
            if (product == 0)
            {
                return 0;
            }
            // Se esce 1, vince il giocatore 1
            else if (product == 1)
            {
                return 1;
            }
            // Se esce 8, vince il giocatore 2
            else if (product == 8)
            {
                return 2;
            }
            else
            {
                return 0;
            }
           
        }
    }
}