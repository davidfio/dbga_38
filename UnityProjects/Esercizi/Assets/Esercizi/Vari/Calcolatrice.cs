using UnityEngine;
using System.Collections;

public class Calcolatrice : MonoBehaviour
{
public int valore1 = 0;
public int valore2 = 0;

    void Update ()
    {
       string inputString = Input.inputString;

       if(inputString.Length > 0)
       {
            char inputChar = inputString[0];        //array

            float result = 0;
            //Switch case per fare le operazioni
            switch (inputChar)
            {
                case '+':
                    result = valore1 + valore2;
                    break;

                case '-':
                    result = valore1 - valore2;
                    break;

                case '*':
                    result = valore1 * valore2;
                    break;

                case '/':
                    result = (float)valore1 / valore2;
                    break;
            }
            Debug.Log("Il risultato è: " + result);
       }
    }
}