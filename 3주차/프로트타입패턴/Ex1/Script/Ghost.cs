using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Monster
{
    int hp;
    int speed;

    public Ghost(int h, int s)
    {
        hp = h;
        speed = s;
    }

    public override Monster clone()
    {
        return new Ghost(hp, speed);
    }
}
