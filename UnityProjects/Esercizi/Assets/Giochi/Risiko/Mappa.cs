using UnityEngine;
using System.Collections;

namespace Risiko
{
    public class Mappa : MonoBehaviour
    {
        public int n_rows = 6;
        public int n_cols = 7;
        public Cell cellPrefabToSpawn;
        public Cell[,] map;

        void Start()
        {
            Debug.Log("Clicca una cella rossa per selezionare l'area del primo attacco\n-----------------------------------------------------------------------");
            Cell variableState = FindObjectOfType<Cell>();
            map = new Cell[n_rows, n_cols];

            for (int i = 0; i < n_rows; i++)
            {
                for (int j = 0; j < n_cols; j++)
                {
                    Cell newCell = Instantiate(cellPrefabToSpawn);
                    newCell.transform.position = new Vector3(j - 4, i + 3, 0);
                    newCell.name = "Regione " + i + " " + j;
                    SpriteRenderer sprite_cell = newCell.GetComponent<SpriteRenderer>();
                    int number = Random.Range(0, 3);

                    switch (number)
                    {
                        case 0:
                            sprite_cell.color = Color.red;
                            newCell.state = number;
                            variableState.state = 0;
                            break;

                        case 1:
                            sprite_cell.color = Color.blue;
                            newCell.state = number;
                            variableState.state = 1;
                            break;

                        case 2:
                            sprite_cell.color = Color.yellow;
                            newCell.state = number;
                            variableState.state = 2;
                            break;
                    }
                    int number2 = Random.Range(1, 7);
                    newCell.GetComponentInChildren<TextMesh>().text = number2.ToString();
                    map[i, j] = newCell;
                    map[i, j].index_i = i;
                    map[i, j].index_j = j;
                }
            }
            Destroy(cellPrefabToSpawn.gameObject);
        }
        
        /*public bool ControlloRegioni (int cell_i, int cell_j, Vector2 direction, int player)
        {

            int sel_i = cell_i + (int)direction.x;
            int sel_j = cell_j + (int)direction.y;

            if (sel_i < 0)
                return false;

            if (sel_j < 0)
                return false;

            if (sel_i < n_rows)
                return false;

            if (sel_i < n_cols)
                return false;

            //return map[sel_i, sel_j].state == gioc;
            return true;
        }*/
    }
}
