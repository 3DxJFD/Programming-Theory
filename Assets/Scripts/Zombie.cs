using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        DoAttack();
    }

    public override void DoAttack()
    {

        
        // health -= 15; //do Eat Brain Attack
    }
}
