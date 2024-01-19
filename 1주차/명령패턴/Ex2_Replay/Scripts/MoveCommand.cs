using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command
{
    Player p;
    float x, z;

    public MoveCommand(float _x, float _z, Player _p)
    {
        x = _x;
        z = _z;
        p = _p;
    }

    public override void Execute()
    {
        p.Move(x, z);
    }
}
