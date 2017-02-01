using UnityEngine;
using System.Collections;

public class Auto
{
    // Stato della macchina le differenze tra una e l'altra
    //Color color;
    const int nWheels = 4;
    string model;
    //string IDtelaio;

    bool isOn = false;
    float speed = 0.0f;

    // Comportamento
    public void Initialize(Color _color, string _IDtelaio)
    {
        //color = _color;
        //IDtelaio = _IDtelaio;
    }

    public void SetModel(string _model)
    {
        this.model = _model;
    }
    
    public void TurnOn()
    {
        isOn = true;
    }

    public void TurnOff()
    {
        isOn = false;
    }

    public void Accelerate()
    {
        if (isOn)
            speed += 1.0f;
    }

    public void Brake()
    {
        if (speed > 0)
            speed -= 1.0f;
    }

    public string GetStatus()
    {
        return " è accesa? " + isOn + "\nProcede ad una velocità pari a " + speed + " km/h";
    }

    public string GetModel()
    {
        return model;
    }
}
