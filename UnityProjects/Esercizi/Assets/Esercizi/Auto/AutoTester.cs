using UnityEngine;
using System.Collections;

public class AutoTester : MonoBehaviour
{
    
	void Start ()
    {
        // Creiamo 3 macchina (gialla, rossa e blu) e le portiamo ad una velocità di 10km/h
        Auto car1, car2, car3;
        car1 = new Auto();
        car2 = new Auto();
        car3 = new Auto();
        car1.Initialize(Color.yellow, "C20");
        car2.Initialize(Color.red, "D65");
        car3.Initialize(Color.blue, "Z90");
        car1.SetModel("Fiat Panda");
        car2.SetModel("Renault Clio");
        car3.SetModel("Hyundai Tucson");
        car1.TurnOn();
        car2.TurnOn();
        car3.TurnOn();

        for (int i = 0; i < 60; i++)
        {
            car1.Accelerate();
            car2.Accelerate();
            car3.Accelerate();
        }
        Debug.Log(car1.GetModel() + car1.GetStatus());
        Debug.Log(car2.GetModel() + car2.GetStatus());
        Debug.Log(car3.GetModel() + car3.GetStatus());
    }
}
