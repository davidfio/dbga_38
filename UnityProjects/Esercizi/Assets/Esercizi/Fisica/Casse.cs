using UnityEngine;
using System.Collections;

public class Casse : MonoBehaviour {

    public int numCol, numRow;
    public int offsetX, offsetY;
    public GameObject casseToSpawn;

    public void Start()
    {
        
        for (int i = 0; i < numRow; i++)
        {
            for (int j = 0; j < numCol; j++)
            {
                GameObject boxes = Instantiate(casseToSpawn);
                //SpriteRenderer srColor = boxes.GetComponent<SpriteRenderer>();
                //srColor.color = Color.red;
                boxes.transform.position = new Vector3(offsetX, i + offsetY, 0);
            }
            
            
        }
         
    }
}