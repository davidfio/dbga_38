using UnityEngine;
using System.Collections;

public class MorraCinese : MonoBehaviour
{
    int PunteggioGiocatore = 0;
    int PunteggioComputer = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            Debug.Log("/////////////////////////////////////////");
            Debug.Log("Giocatore sceglie.. SASSO!");
            int RandomNumber = Random.Range(0,3);
            switch(RandomNumber)
            {
                case 0:
                Debug.Log("Computer sceglie.. SASSO!");
                Debug.Log("Parità");
                break;

                case 1:
                Debug.Log("Computer sceglie.. CARTA!");
                Debug.Log("Punto al Computer!");
                PunteggioComputer++;
                break;

                case 2:
                Debug.Log("Computer sceglie.. FORBICI!");
                Debug.Log("Punto al Giocatore!");
                PunteggioGiocatore++;
                break;
            }
                Debug.Log("Giocatore " + PunteggioGiocatore + " - " + PunteggioComputer + " Computer");
        }

        else if (Input.GetKeyDown(KeyCode.Keypad1))
        {
             Debug.Log("/////////////////////////////////////////");
             Debug.Log("Giocatore sceglie.. CARTA!");
             int RandomNumber2 = Random.Range(0, 3);
             switch (RandomNumber2)
             {
                case 0:
                Debug.Log("Computer sceglie.. SASSO!");
                Debug.Log("Punto al Giocatore!");
                PunteggioGiocatore++;
                break;

                case 1:
                Debug.Log("Computer sceglie.. CARTA!");
                Debug.Log("Parità");
                break;

                case 2:
                Debug.Log("Computer sceglie.. FORBICI!");
                Debug.Log("Punto al Computer!");
                PunteggioComputer++;
                break;
             }
                Debug.Log("Giocatore " + PunteggioGiocatore + " - " + PunteggioComputer + " Computer");
        }

        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
              Debug.Log("/////////////////////////////////////////");
              Debug.Log("Giocatore sceglie.. FORBICI!");
              int RandomNumber3 = Random.Range(0, 3);
              switch (RandomNumber3)
              {
                  case 0:
                  Debug.Log("Computer sceglie.. SASSO!");
                  Debug.Log("Punto al Computer!");
                  PunteggioComputer++;
                  break;

                  case 1:
                  Debug.Log("Computer sceglie.. CARTA!");
                  Debug.Log("Punto al Giocatore!");
                  PunteggioGiocatore++;
                  break;

                  case 2:
                  Debug.Log("Computer sceglie.. FORBICI!");
                  Debug.Log("Parità");
                  break;
              }
                  Debug.Log("Giocatore " + PunteggioGiocatore + " - " + PunteggioComputer + " Computer");
        }
    }
}