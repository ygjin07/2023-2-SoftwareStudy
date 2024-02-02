using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : Subject
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            notify(Event_enum.Press_F);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            notify(Event_enum.Press_G);
        }
    }
}
