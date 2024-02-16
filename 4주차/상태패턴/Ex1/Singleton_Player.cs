using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton_Player : MonoBehaviour
{
    State state;
    State_Q sq;
    State_W sw;
    State_E se;
    State_R sr;


    // Start is called before the first frame update
    void Start()
    {
        sq = new State_Q();
        sw = new State_W();
        se = new State_E();
        sr = new State_R();
        state = sq;
    }

    // Update is called once per frame
    void Update()
    {
        state.handleInput(this);
    }

    public void ChangeToQ()
    {
        state = sq;
    }
    public void ChangeToW()
    {
        state = sw;
    }
    public void ChangeToE()
    {
        state = se;
    }
    public void ChangeToR()
    {
        state = sr;
    }
}
