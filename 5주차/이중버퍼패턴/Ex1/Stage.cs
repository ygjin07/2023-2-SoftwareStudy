using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    List<Actor> actors;

    // Start is called before the first frame update
    void Start()
    {
        actors = new List<Actor>();

        Comedian harry = new Comedian("harry");
        Comedian baldy = new Comedian("baldy");
        Comedian chump = new Comedian("chump");

        harry.face(baldy);
        baldy.face(chump);
        chump.face(harry);

        actors.Add(harry);
        actors.Add(baldy);
        actors.Add(chump);

        actors[2].slap();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Action();
        }
    }

    private void Action()
    {
        foreach (Actor a in actors)
        {
            a.update();
        }
        foreach (Actor a in actors)
        {
            a.swap();
        }
    }
}
