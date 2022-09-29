using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] //Encapsulation
    private int m_Health;
    public int health
    {
        get { return m_Health; }
        set { m_Health = 100; }
    }

    public float GetHealth()
    {
        return health;
    }
    public void TakeDamage()
    {
        m_Health -= 10;
    }
}
