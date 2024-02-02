using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    List<Observer> observers = new List<Observer>();

    public void addObserver(Observer observer)
    {
        observers.Add(observer);
    }

    public void removeObserver(Observer observer)
    {
        observers.Remove(observer);
    }

    protected void notify(Event_enum e)
    {
        foreach(Observer o in observers)
        {
            o.onNotify(e);
        }
    }
}
