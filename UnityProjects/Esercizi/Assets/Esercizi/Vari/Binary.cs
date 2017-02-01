using UnityEngine;
using System.Collections;

public class Binary : MonoBehaviour
{
    void Start ()
    {
        // Let's define some variables 
        int bit0 = 1;
        int bit1 = 0;
        int bit2 = 0;
        int bit3 = 0;
        int bit4 = 0;
        int bit5 = 0;
        int bit6 = 0;
        int bit7 = 1;

        // Let's create an algorithm that will convert an integer to its binary representation
        // WARNING: only 8 bits
        float number = Mathf.Pow(2, 0) * bit0
                     + Mathf.Pow(2, 1) * bit1
                     + Mathf.Pow(2, 2) * bit2
                     + Mathf.Pow(2, 3) * bit3
                     + Mathf.Pow(2, 4) * bit4
                     + Mathf.Pow(2, 5) * bit5
                     + Mathf.Pow(2, 6) * bit6
                     + Mathf.Pow(2, 7) * bit7;
        Debug.Log(number);
    }
}