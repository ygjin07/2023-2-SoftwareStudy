using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command
{
    public virtual void Execute() { }
}

public class HelloCommand : Command
{
    public override void Execute()
    {
        Debug.Log("hello");
    }
}

public class ByeCommand : Command
{
    public override void Execute()
    {
        Debug.Log("bye");
    }
}

public class AttackCommand : Command
{
    public override void Execute()
    {
        Debug.Log("attack");
    }
}

public class WalkCommand : Command
{
    public override void Execute()
    {
        Debug.Log("walk");
    }
}