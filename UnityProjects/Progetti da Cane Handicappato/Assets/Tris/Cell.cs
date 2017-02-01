using UnityEngine;
using System.Collections;

public class Cell : MonoBehaviour {

    public int state = 0;
    public AudioClip clickPlayer1;
    public AudioClip clickPlayer2;
    public AudioClip clickWin;
    public AudioClip soundDraw;
    public AudioSource audioSource;
    
    void OnMouseUp()
    {

        Grid rifGrid = FindObjectOfType<Grid>();

        if (state == 0 && rifGrid.isPlayable == true)
        {
           
            if (rifGrid.currentPlayer == (int)Grid.Players.Player1)
            {
                SpriteRenderer sr = this.GetComponent<SpriteRenderer>();
                sr.color = Color.red;
                rifGrid.currentPlayer = (int)Grid.Players.Player2;
                state = 1;
                audioSource.clip = clickPlayer1;
                audioSource.Play();
            }
            else if (rifGrid.currentPlayer == (int)Grid.Players.Player2)
            {
                SpriteRenderer sr = this.GetComponent<SpriteRenderer>();
                sr.color = Color.yellow;
                rifGrid.currentPlayer = (int)Grid.Players.Player1;
                state = 2;
                audioSource.clip = clickPlayer2;
                audioSource.Play();
            }

        }
        rifGrid.CheckWinner();
    }
}
