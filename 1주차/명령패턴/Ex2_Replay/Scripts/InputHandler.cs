using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{
    Player player;
    float Speed = 3;

    public InputHandler (Player p)
    {
        player = p;
    }

    public void handleInput()
    {
        Command command;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            command = new MoveCommand(0, Speed * Time.deltaTime, player);
            command.Execute();
            TimeLineManager.TLM.AddList(command, ReplayMain.RM.GetTime());
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            command = new MoveCommand(0, -Speed * Time.deltaTime, player);
            command.Execute();
            TimeLineManager.TLM.AddList(command, ReplayMain.RM.GetTime());
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            command = new MoveCommand(Speed * Time.deltaTime, 0, player);
            command.Execute();
            TimeLineManager.TLM.AddList(command, ReplayMain.RM.GetTime());
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            command = new MoveCommand(-Speed * Time.deltaTime, 0, player);
            command.Execute();
            TimeLineManager.TLM.AddList(command, ReplayMain.RM.GetTime());
        }
    }
}
