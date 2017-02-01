using UnityEngine;
using System.Collections;

public class DiceMono : MonoBehaviour
{
    public Sprite baseSprite;
    private int nFaces;
    private TextMesh numberTextMesh;

    public void Awake()
    {
        SpriteRenderer sr = this.gameObject.AddComponent<SpriteRenderer>(); // aggiungo sr che è uno SpriteRenderer
        sr.sprite = baseSprite;
        Transform tr = this.transform; // aggiungo tr che è una variabile a cui ho assegnato la transform localScale 
        tr.localScale = new Vector3(10, 10, 10);

        GameObject childGo = new GameObject("TextMeshGO"); //creo nuovo GameObject 'childGO' chiamato TextMeshGO
        childGo.transform.position = tr.position + new Vector3 (0,0,-1);
        childGo.transform.localScale = Vector3.one * 0.5f;
        
        TextMesh textMesh = childGo.AddComponent<TextMesh>();
        textMesh.text = "5";
        textMesh.color = Color.black;
        textMesh.alignment = TextAlignment.Center;
        textMesh.anchor = TextAnchor.MiddleCenter;
        numberTextMesh = textMesh;
        
        // tiriamo un dado e cambiamo la faccia
        SetFaces(6);
        Throw();
    }

    public void SetFaces(int a)
    {
        this.nFaces = a;
    }

    public int Throw()
    {
        int n = Random.Range(1, nFaces + 1);
        numberTextMesh.text = n.ToString();
        return n;
    }
}
