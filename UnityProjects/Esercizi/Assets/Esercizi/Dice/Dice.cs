using UnityEngine;
using System.Collections;

public class Dice
{
    private int nFaces;

    public void SetFaces(int nFaces1)
    {
        this.nFaces = nFaces1; // this è una keyword che da un riferimento a se stesso
    }

    public int Throw()
    {
        return Random.Range(1, nFaces + 1);
    }
}
