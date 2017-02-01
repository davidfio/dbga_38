using UnityEngine;
using System.Collections;

public class MAIUSC : MonoBehaviour
{
public string parola;

	void Update ()
    {
        char a = 'a';
        string parolaconvertita = "";

        for (int i=0; i<parola.Length; i++)
        {
            a = parola[i];
            switch(a)
            {
                case 'a':
                case 'A':
                a = 'A';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'b':
                case 'B':
                a = 'B';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'c':
                case 'C':
                a = 'C';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'd':
                case 'D':
                a = 'D';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'e':
                case 'E':
                a = 'E';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'f':
                case 'F':
                a = 'F';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'g':
                case 'G':
                a = 'G';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'h':
                case 'H':
                a = 'H';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'i':
                case 'I':
                a = 'I';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'l':
                case 'L':
                a = 'L';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'm':
                case 'M':
                a = 'M';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'n':
                case 'N':
                a = 'N';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'o':
                case 'O':
                a = 'O';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'p':
                case 'P':
                a = 'P';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'q':
                case 'Q':
                a = 'Q';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'r':
                case 'R':
                a = 'R';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 's':
                case 'S':
                a = 'S';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 't':
                case 'T':
                a = 'T';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'u':
                case 'U':
                a = 'U';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'v':
                case 'V':
                a = 'V';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'z':
                case 'Z':
                a = 'Z';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'x':
                case 'X':
                a = 'X';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'y':
                case 'Y':
                a = 'Y';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'w':
                case 'W':
                a = 'W';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case ' ':
                a = ' ';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'j':
                case 'J':
                a = 'J';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;

                case 'k':
                a = 'K';
                parolaconvertita = parolaconvertita.Insert(i, a.ToString());
                break;
            }
            Debug.Log(parolaconvertita);
        }
	}
}
