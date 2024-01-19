using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLine
{
    public Command command;
    public float time;

    public TimeLine(Command _c, float _t)
    {
        command = _c;
        time = _t;
    }
}
