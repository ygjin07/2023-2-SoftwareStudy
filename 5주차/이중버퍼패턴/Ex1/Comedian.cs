using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comedian : Actor
{
    private Actor facing;

    public Comedian(string n) : base(n)
    {
    }

    public override void update()
    {
        if(wasSlapped())
        {
            facing.slap();
        }
    }

    public void face(Actor a)
    {
        facing = a;
    }
}
