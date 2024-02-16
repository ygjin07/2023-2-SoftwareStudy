using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public virtual void handleInput(Singleton_Player player)
    {
    }
}

public class State_Q : State 
{
    public override void handleInput(Singleton_Player player)
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.ChangeToW();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.ChangeToE();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            player.ChangeToR();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Q");
        }
    }
}

public class State_W : State
{
    public override void handleInput(Singleton_Player player)
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            player.ChangeToQ();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.ChangeToE();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            player.ChangeToR();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("W");
        }
    }
}
public class State_E : State
{
    public override void handleInput(Singleton_Player player)
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            player.ChangeToQ();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.ChangeToW();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            player.ChangeToR();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("E");
        }
    }
}
public class State_R : State
{
    public override void handleInput(Singleton_Player player)
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            player.ChangeToQ();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.ChangeToW();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.ChangeToE();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("R");
        }
    }
}