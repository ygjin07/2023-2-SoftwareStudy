using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Event_enum
{ 
Press_F,
Press_G
};

public class Achievments : Observer
{
    Achievment achievment_f, achievment_g;
    Subject player;

    // Start is called before the first frame update
    void Start()
    {
        achievment_f = new Achievment("new Achievment! : Press F!");
        achievment_g = new Achievment("new Achievment! : Press G!");
        player = GameObject.Find("Player").GetComponent<PlayerInput>();
        player.addObserver(this);
    }

    public override void onNotify(Event_enum e)
    {
        switch(e)
        {
            case Event_enum.Press_F:
                if(achievment_f.isLock)
                    achievment_f.Unlock();
                break;
            case Event_enum.Press_G:
                if (achievment_g.isLock)
                    achievment_g.Unlock();
                break;
        }
    }
}

public class Achievment
{
    public bool isLock = true;
    string unlock_message;

    public Achievment(string message)
    {
        unlock_message = message;
    }

    public void Unlock()
    {
        Debug.Log(unlock_message);
        isLock = false;
    }
}
