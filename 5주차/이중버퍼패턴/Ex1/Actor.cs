using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor
{
    private bool current_slapped = false;
    private bool next_slapped = false;
    private string name;

    public Actor(string n)
    {
        name = n;
    }

    public virtual void update()
    { }

    public void swap()
    {
        current_slapped = next_slapped;
        next_slapped = false;
    }

    public void slap()
    {
        Debug.Log(name + " slap");
        next_slapped = true;
    }

    public bool wasSlapped()
    {
        return current_slapped;
    }
}
