using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSingleton : MonoBehaviour
{
    public static SimpleSingleton singleton;

    // Start is called before the first frame update
    void Start()
    {
        if(singleton != null)
        {
            singleton = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
