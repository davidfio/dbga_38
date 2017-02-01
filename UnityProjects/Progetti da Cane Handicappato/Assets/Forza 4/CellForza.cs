using UnityEngine;
using System.Collections;

public class CellForza : MonoBehaviour {

    public int state = 0;
    public bool isPlayable = false;

	void OnMouseUp()
    {
        GridForza rifGrid = FindObjectOfType<GridForza>();
        SpriteRenderer sr = this.GetComponent<SpriteRenderer>();

        if (state == 0 && isPlayable == true)
        {
            if (rifGrid.currentPlayer == (int)Grid.Players.Player1)
            {
                sr.color = Color.red;
                state = 1;
                rifGrid.currentPlayer = (int)Grid.Players.Player2;

            }
            else if (rifGrid.currentPlayer == (int)Grid.Players.Player2)
            {
                sr.color = Color.yellow;
                state = 2;
                rifGrid.currentPlayer = (int)Grid.Players.Player1;
            }
        }

        //rifGrid.CheckWinner();

    }
}
