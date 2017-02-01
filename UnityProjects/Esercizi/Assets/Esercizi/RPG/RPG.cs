using UnityEngine;
using System.Collections;

public class RPG
{
    // Stato
    int forza;
    int vita;
    int destrezza;
    bool isDead = false;

    // Comportamento
    public void Initialize(int _forza, int _vita, int _destrezza)
    {
        this.forza = _forza;
        this.vita = _vita;
        this.destrezza = _destrezza;
    }

    public bool CheckHealth()
    {
        if (vita <= 0)
            return isDead = true;
        else
            return isDead;
    }

    public void Hit(int danno)
    {
        vita -= danno;
        if (vita < 0)
            vita = 0;
    }

    public int GetStrenght()
    {
        return forza;
    }

    public int GetHealth()
    {
        return vita;
    }

    public int GetDex()
    {
        return destrezza;
    }
}
