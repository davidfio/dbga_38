using UnityEngine;
using System.Collections;

public class GridForza : MonoBehaviour {

    public GameObject cellToSpawn;
    public int nCol = 6; // X
    public int nRow = 7; // Y
    int nCell;
    enum Players { Null, Player1, Player2 }
    public int currentPlayer = (int)Players.Player1;

	
	void Start ()
    {
        for (int i = 0; i < nRow; i++)
        {
            for (int j = 0; j < nCol; j++)
            {
                //CellForza rifCellForza = FindObjectOfType<CellForza>();
                GameObject cellGo = Instantiate(cellToSpawn);
                cellGo.transform.position = new Vector2(j - 3f, i - 2.5f);
                cellGo.name = "Cella " + nCell++;

                if (i == 0)
                    {
                        cellGo.GetComponent<CellForza>().isPlayable = true;
                    }
            }
        }           
	}
	
}
