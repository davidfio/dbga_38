using UnityEngine;
using System.Collections;
using Risiko;

public class Cell : MonoBehaviour
{
    public int state;
    //TextMesh NumeroCarroArmati;
    Color colore = new Color(1, 1, 1, 1);
    public SpriteRenderer childComponent;
    public int index_i;
    public int index_j;

    public void Awake()
    {
        TextMesh textMesh = this.GetComponentInChildren<TextMesh>();
        textMesh.color = Color.black;
        //NumeroCarroArmati = textMesh;
    }

    void OnMouseUp()
    {
        GameController phases = FindObjectOfType<GameController>();
        

        if (phases.phase == 1)
        {
            if (state == 0)
            {
                Control();
                childComponent.color = colore;
            }
            phases.phase = 2;
        }
    }

    void Control()
    {
        Mappa control = FindObjectOfType<Mappa>();

        if (index_i == 0)
        {
            if (index_j == 0)
            {
                if (control.map[index_i + 1, index_j].state != this.state)
                    control.map[index_i + 1, index_j].childComponent.color = Color.red;
                if (control.map[index_i, index_j + 1].state != this.state)
                    control.map[index_i, index_j + 1].childComponent.color = Color.red;
            }

            if (index_j == 6)
            {
                if (control.map[index_i + 1, index_j].state != this.state)
                    control.map[index_i + 1, index_j].childComponent.color = Color.red;
                if (control.map[index_i, index_j - 1].state != this.state)
                    control.map[index_i, index_j - 1].childComponent.color = Color.red;
            }

            if (index_j < 6 && index_j > 0)
            {
                if (control.map[index_i, index_j - 1].state != this.state)
                    control.map[index_i, index_j - 1].childComponent.color = Color.red;
                if (control.map[index_i + 1, index_j].state != this.state)
                    control.map[index_i + 1, index_j].childComponent.color = Color.red;
                if (control.map[index_i, index_j + 1].state != this.state)
                    control.map[index_i, index_j + 1].childComponent.color = Color.red;
            }

        }
        if (index_j == 0)
        {
            if (index_i == 5)
            {
                if (control.map[index_i - 1, index_j].state != this.state)
                    control.map[index_i - 1, index_j].childComponent.color = Color.red;
                if (control.map[index_i, index_j + 1].state != this.state)
                    control.map[index_i, index_j + 1].childComponent.color = Color.red;
            }

            if (index_i < 5 && index_i > 0)
            {
                if (control.map[index_i - 1, index_j].state != this.state)
                    control.map[index_i - 1, index_j].childComponent.color = Color.red;
                if (control.map[index_i + 1, index_j].state != this.state)
                    control.map[index_i + 1, index_j].childComponent.color = Color.red;
                if (control.map[index_i, index_j + 1].state != this.state)
                    control.map[index_i, index_j + 1].childComponent.color = Color.red;
            }
        }

        if (index_j == 6)
        {
            if (index_i == 5)
            {
                if (control.map[index_i - 1, index_j].state != this.state)
                    control.map[index_i - 1, index_j].childComponent.color = Color.red;
                if (control.map[index_i, index_j - 1].state != this.state)
                    control.map[index_i, index_j - 1].childComponent.color = Color.red;
            }

            if (index_i < 5 && index_i > 0)
            {
                if (control.map[index_i, index_j - 1].state != this.state)
                    control.map[index_i, index_j - 1].childComponent.color = Color.red;
                if (control.map[index_i + 1, index_j].state != this.state)
                    control.map[index_i + 1, index_j].childComponent.color = Color.red;
                if (control.map[index_i - 1, index_j].state != this.state)
                    control.map[index_i - 1, index_j].childComponent.color = Color.red;
            }
        }
        
        if (index_i == 5 && index_j < 6 && index_j > 0)
        {
            if (control.map[index_i, index_j - 1].state != this.state)
                control.map[index_i, index_j - 1].childComponent.color = Color.red;
            if (control.map[index_i, index_j + 1].state != this.state)
                control.map[index_i, index_j + 1].childComponent.color = Color.red;
            if (control.map[index_i - 1, index_j].state != this.state)
                control.map[index_i - 1, index_j].childComponent.color = Color.red;
        }

        if (index_j > 0 && index_j < 6 && index_i < 5 && index_i > 0)
        {
            if (control.map[index_i, index_j - 1].state != this.state)
                control.map[index_i, index_j - 1].childComponent.color = Color.red;
            if (control.map[index_i, index_j + 1].state != this.state)
                control.map[index_i, index_j + 1].childComponent.color = Color.red;
            if (control.map[index_i - 1, index_j].state != this.state)
                control.map[index_i - 1, index_j].childComponent.color = Color.red;
            if (control.map[index_i + 1, index_j].state != this.state)
                control.map[index_i + 1, index_j].childComponent.color = Color.red;
        }
    }
}