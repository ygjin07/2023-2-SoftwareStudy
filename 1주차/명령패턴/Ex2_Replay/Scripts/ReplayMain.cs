using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayMain : MonoBehaviour
{
    public static ReplayMain RM;
    public Player player;
    InputHandler InHan;
    float time = 0;
    bool isplay = false, isreplay = false;
    int idx = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(!RM)
        {
            RM = this;
        }
        else
        {
            Destroy(this);
        }
        InHan = new InputHandler(player);
    }

    // Update is called once per frame
    void Update()
    {
        if (isplay)
        {
            time += Time.deltaTime;
            InHan.handleInput();
        }
        else if(isreplay)
        {
            time += Time.deltaTime;
            if(idx < TimeLineManager.TLM.TLList.Count)
            {
                TimeLine currentTimeLine = TimeLineManager.TLM.TLList[idx];
                while(currentTimeLine.time <= time)
                {
                    idx++;
                    currentTimeLine.command.Execute();
                    if (idx < TimeLineManager.TLM.TLList.Count)
                    {
                        currentTimeLine = TimeLineManager.TLM.TLList[idx];
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                Finish();
            }
        }
    }

    public float GetTime()
    {
        return time;
    }

    public void ResetTime()
    {
        time = 0;
    }

    public void Play()
    {
        ResetTime();
        TimeLineManager.TLM.ResetTimeLine();
        isplay = true;
    }
    public void Replay()
    {
        ResetTime();
        idx = 0;
        isreplay = true;
    }
    public void Finish()
    {
        isplay = false;
        isreplay = false;
        player.Reset();
    }
}
