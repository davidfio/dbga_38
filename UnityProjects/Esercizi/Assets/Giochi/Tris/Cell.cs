using UnityEngine;
using System.Collections;
using Tris;

public class Cella : MonoBehaviour
{
    public int state = 0; // 0=vuota, 1=x, 2=O

    void OnMouseUp() // Metodo della classe Cell
    {
        Debug.Log("Hai premuto " + gameObject.name);

        // Se la cella è vuota
        if(state == 0)
        {
            // Crea una variabile pippogrid di tipo grid, poi va ricercare nel progetto la grid (la prima che trova)
            Grid pippoGrid = FindObjectOfType<Grid>();

            // Se il giocatore è X
            if (pippoGrid.currentPlayer ==1)
            {
                SpriteRenderer sr = GetComponent<SpriteRenderer>();
                sr.color = Color.red;
                state = 1;
                pippoGrid.currentPlayer = 2;
            }
            // Se invece il giocatore è O
            else
            {
                SpriteRenderer sr = GetComponent<SpriteRenderer>();
                sr.color = Color.green;
                state = 2;
                pippoGrid.currentPlayer = 1;
            }
            pippoGrid.CheckWinner();
        }
    }
}