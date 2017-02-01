using UnityEngine;
using System.Collections;

namespace AI.PCG
{
    public class DungeonCell : MonoBehaviour
    {
        public bool isWall;
        public int i, j; 


        public void SetWall()
        {
            this.GetComponent<MeshRenderer>().material.color = Color.green;
            isWall = true;
        }

        public void SetEmpty()
        {
            this.GetComponent<MeshRenderer>().material.color = Color.black;
            isWall = false;
        }

    }
}