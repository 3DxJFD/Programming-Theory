using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [SerializeField] //Encapsulation
    private int health;
    public int Health
    {
        get { 
                return health; 
            }
        
        set {
            if (value < 0)
                health = 0;
            else if (value > 100)
                health = 100;
            else
                health = value; 
        }
    }

    public float GetHealth()
    {
        return health;
    }
    public void TakeDamage()
    {
        health -= 10;
    }
}
