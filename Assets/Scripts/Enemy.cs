using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Inheritance Enemy -> Goblin & Zombie

    public virtual void DoAttack()
    {
        //m_Health -= 10;
    }
}
