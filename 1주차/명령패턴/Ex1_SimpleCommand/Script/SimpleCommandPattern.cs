using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCommandPattern : MonoBehaviour
{
    Command btn_q, btn_w, btn_e, btn_r;

    // Start is called before the first frame update
    void Start()
    {
        btn_q = new HelloCommand();
        btn_w = new ByeCommand();
        btn_e = new AttackCommand();
        btn_r = new WalkCommand();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            btn_q.Execute();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            btn_w.Execute();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            btn_e.Execute();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            btn_r.Execute();
        }
    }
}
