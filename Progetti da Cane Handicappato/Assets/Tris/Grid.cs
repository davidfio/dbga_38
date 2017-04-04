using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Grid : MonoBehaviour {

    public GameObject cellToSpawn;
    public enum Players { Null, Player1, Player2, }
    public int currentPlayer = (int)Players.Player1;
    public bool isPlayable = true; 

	void Start ()
    {

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                GameObject cellGo = Instantiate(cellToSpawn);
                cellGo.transform.position = new Vector2((1.5f * i)-1.5f, (j * 1.5f)-1.5f);
                cellGo.name = "Cella " + i +", "+ j ;
            }
        }
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Tris");
        }
    }

    public void CheckWinner()
    {
        Cell[] arrayCells = FindObjectsOfType<Cell>();
        Cell rifCell = FindObjectOfType<Cell>();

        // Controllo le Colonne
        int resCheck = DidSomeoneWin(arrayCells[8].state, arrayCells[7].state, arrayCells[6].state);
        if (resCheck > 0 && isPlayable == true)
        {
            Debug.Log("Ha vinto il Giocatore " + resCheck);
            rifCell.audioSource.clip = rifCell.clickWin;
            rifCell.audioSource.Play();
            isPlayable = false;
            return;
        }

        resCheck = DidSomeoneWin(arrayCells[5].state, arrayCells[4].state, arrayCells[3].state);
        if (resCheck > 0 && isPlayable == true)
        {
            Debug.Log("Ha vinto il Giocatore " + resCheck);
            rifCell.audioSource.clip = rifCell.clickWin;
            rifCell.audioSource.Play();
            isPlayable = false;
            return;
        }

        resCheck = DidSomeoneWin(arrayCells[2].state, arrayCells[1].state, arrayCells[0].state);
        if (resCheck > 0 && isPlayable == true)
        {
            Debug.Log("Ha vinto il Giocatore " + resCheck);
            rifCell.audioSource.clip = rifCell.clickWin;
            rifCell.audioSource.Play();
            isPlayable = false;
            return;
        }

        // Controllo le Righe
        resCheck = DidSomeoneWin(arrayCells[8].state, arrayCells[5].state, arrayCells[2].state);
        if (resCheck > 0 && isPlayable == true)
        {
            Debug.Log("Ha vinto il Giocatore " + resCheck);
            rifCell.audioSource.clip = rifCell.clickWin;
            rifCell.audioSource.Play();
            isPlayable = false;
            return;
        }

        resCheck = DidSomeoneWin(arrayCells[7].state, arrayCells[4].state, arrayCells[1].state);
        if (resCheck > 0 && isPlayable == true)
        {
            Debug.Log("Ha vinto il Giocatore " + resCheck);
            rifCell.audioSource.clip = rifCell.clickWin;
            rifCell.audioSource.Play();
            isPlayable = false;
            return;
        }

        resCheck = DidSomeoneWin(arrayCells[6].state, arrayCells[3].state, arrayCells[0].state);
        if (resCheck > 0 && isPlayable == true)
        {
            Debug.Log("Ha vinto il Giocatore " + resCheck);
            rifCell.audioSource.clip = rifCell.clickWin;
            rifCell.audioSource.Play();
            isPlayable = false;
            return;
        }

        //Controllo le Diagonali
        resCheck = DidSomeoneWin(arrayCells[8].state, arrayCells[4].state, arrayCells[0].state);
        if (resCheck > 0 && isPlayable == true)
        {
            Debug.Log("Ha vinto il Giocatore " + resCheck);
            rifCell.audioSource.clip = rifCell.clickWin;
            rifCell.audioSource.Play();
            isPlayable = false;
            return;
        }

        resCheck = DidSomeoneWin(arrayCells[2].state, arrayCells[4].state, arrayCells[6].state);
        if (resCheck > 0 && isPlayable == true)
        {
            Debug.Log("Ha vinto il Giocatore " + resCheck);
            rifCell.audioSource.clip = rifCell.clickWin;
            rifCell.audioSource.Play();
            isPlayable = false;
            return;
        }

        int resDraw = 1;
        for (int i = 0; i < arrayCells.Length; i++)
        {
            resDraw *= arrayCells[i].state;
        }
        if (resDraw > 0)
        {
            Debug.Log("Parità!!");
            rifCell.audioSource.clip = rifCell.soundDraw;
            rifCell.audioSource.Play();
        }
    }

    int DidSomeoneWin(int v1, int v2, int v3)
    {
        int product = v1 * v2 * v3;

        if (product == 0)
            return 0;
        else if (product == 1)
            return 1;
        else if (product == 8)
            return 2;
        else
            return 0;
    }
	
}
