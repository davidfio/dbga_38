using UnityEngine;
using System.Collections;

public class Banconote1 : MonoBehaviour
{
public int Cash;

    void Start ()
    {
        //string inputString = Input.inputString;
        // Let's do some operations
        int aa = (int)(Cash / 500);
        Debug.Log(aa + " banconota/e da 500€");
        decimal bb = Cash % 500;
        int cc = (int)(bb / 200);
        Debug.Log(cc + " banconota/e da 200€");
        decimal dd = bb % 200;
        int ee = (int)(dd / 100);
        Debug.Log(ee + " banconota/e da 100€");
        decimal ff = dd % 100;
        int a = (int)(ff / 50);
        Debug.Log(a + " banconota/e da 50€");
        decimal b = ff % 50;
        int c = (int)(b / 20);
        Debug.Log(c + " banconota/e da 20€");
        decimal d = b % 20;
        int e = (int)(d / 10);
        Debug.Log(e + " banconota/e da 10€");
        decimal f = d % 10;
        int g = (int)(f / 5);
        Debug.Log(g + " banconota/e da 5€");
        decimal h = f % 5;
        int i = (int)(h / 2);
        Debug.Log(i + " moneta/e da 2€");
        decimal j = h % 2;
        int k = (int)(j / 1);
        Debug.Log(k + " moneta/e da 1€");
        int l = (int)(j * 100);
        decimal m = l % 100;
        int n = (int)(m / 50);
        Debug.Log(n + " moneta/e da 50 centesimi");
        decimal o = m % 50;
        int p = (int)(o / 20);
        Debug.Log(p + " moneta/e da 20 centesimi");
        decimal q = o % 20;
        int r = (int)(q / 10);
        Debug.Log(r + " moneta/e da 10 centesimi");
        decimal s = q % 10;
        int t = (int)(s / 5);
        Debug.Log(t + " moneta/e da 5 centesimi");
        decimal u = s % 5;
        int v = (int)(u / 2);
        Debug.Log(v + " moneta/e da 2 centesimi");
        decimal w = u % 2;
        int x = (int)(w / 1);
        Debug.Log(x + " moneta/e da 1 centesimo");
    }
}