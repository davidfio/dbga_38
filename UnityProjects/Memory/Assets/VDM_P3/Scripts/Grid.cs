using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Memory
{

    public class Grid : MonoBehaviour
    {
        public const int ROW_LENGTH = 6;
        public const int COL_LENGTH = 4;

        public GameObject prefabCellGo;
        public Cell[,] cellsMatrix;
        public List<Cell> cellsList;

        void Awake()
        {
            // Create the cell matrix
            cellsMatrix = new Cell[ROW_LENGTH, COL_LENGTH];
            for (int i = 0; i < ROW_LENGTH; i++)
            {
                for (int j = 0; j < COL_LENGTH; j++)
                {
                    GameObject newCellGo = Instantiate(prefabCellGo);
                    Cell newCell = newCellGo.GetComponent<Cell>();
                    newCell.transform.position = new Vector3(i - ROW_LENGTH / 2 + 0.5f, j - COL_LENGTH / 2 + 0.5f, 0) * 0.4f;
                    cellsMatrix[i, j] = newCell;
                    cellsList.Add(newCell);
                }
            }

            // Randomize cells
            int pairsNumber = ROW_LENGTH * COL_LENGTH / 2;
            for (int p = 0; p < pairsNumber; p++)
            {
                int chosenIndex;

                chosenIndex = Random.Range(0, cellsList.Count);
                Cell c1 = cellsList[chosenIndex];
                c1.AssignSpriteIndex(p);
                cellsList.RemoveAt(chosenIndex);

                chosenIndex = Random.Range(0, cellsList.Count);
                Cell c2 = cellsList[chosenIndex];
                c2.AssignSpriteIndex(p);
                cellsList.RemoveAt(chosenIndex);
            }
        }

        public void ResetToHidden()
        {
            for (int i = 0; i < ROW_LENGTH; i++)
            {
                for (int j = 0; j < COL_LENGTH; j++)
                {
                    //cellsMatrix[i, j].SetShown();
                    cellsMatrix[i, j].SetHidden();
                    cellsMatrix[i, j].Recolor();
                }
            }
        }
    }

}
