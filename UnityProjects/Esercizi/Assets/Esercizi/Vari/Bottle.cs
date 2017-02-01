using UnityEngine;
using System.Collections;

public struct Bottle{
    public int waterLevel;

    public Bottle(int _waterlevel)
    {
        this.waterLevel = _waterlevel;
    }

    public static Bottle operator +(Bottle b1, Bottle b2)
    {
        Bottle result = new Bottle();
        result.waterLevel = b1.waterLevel + b2.waterLevel;
        return result;
    }
        
}

