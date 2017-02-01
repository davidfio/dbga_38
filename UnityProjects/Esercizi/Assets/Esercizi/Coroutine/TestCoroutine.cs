using UnityEngine;
using System.Collections;

public class TestCoroutine : MonoBehaviour {

	void Start ()
    {
        //StartCoroutine(SayCiaoForever());
        //StartCoroutine(SayCiaoAfterSeconds(2));
        //StartCoroutine(SayCiaoEverySeconds(1));
        //StartCoroutine(SayCiaoTenTimes(1));
        StartCoroutine(DoSomeStuff());
    }


    IEnumerator SayCiaoForever()
    {
        //Esegue fino a questa istruzione, poi aspetta il frame successivo, 
        //poi esegue il resto
        yield return null; // Salta al prossimo frame
        
        while (true)
        {

            Debug.Log("CIAO");

            yield return null;
        }
    }

    IEnumerator SayCiaoAfterSeconds (int seconds)
    {
        yield return new WaitForSeconds(seconds);
        Debug.Log("CIAO");     
    }

    IEnumerator SayCiaoEverySeconds(int seconds)
    {
        while (true)
        {
            yield return new WaitForSeconds(seconds);
            Debug.Log("Ciao");
        }
    }

    IEnumerator SayCiaoTenTimes(int seconds)
    {
        int count = 0;
        while (true)
        {
            yield return new WaitForSeconds(seconds);
            Debug.Log("CIAOOOOO");
            count++;

            if (count == 10)
            {
                yield break; // Esce dall'esecuzione ad una determinata condizione
            }
        }
    }

    IEnumerator DoSomeStuff()
    {
        // Diciamo Ciao dopo due secondi
        yield return StartCoroutine(SayCiaoAfterSeconds(2));

        // Diciamo "E BASTA CIAO"
        Debug.Log("E BASTA CIAO");

        // Diciamo "scusa..." dopo 3 secondi
        yield return new WaitForSeconds(3);

        Debug.Log("scusa...");

    }

}
