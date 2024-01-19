using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLineManager : MonoBehaviour
{
    public static TimeLineManager TLM;
    public List<TimeLine> TLList = new List<TimeLine>();

    // Start is called before the first frame update
    void Start()
    {
        if(!TLM)
        {
            TLM = this;
        }
        else
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddList(Command c, float time)
    {
        TLList.Add(new TimeLine(c, time));
    }

    public void ResetTimeLine()
    {
        TLList.Clear();
    }
}
