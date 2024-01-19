using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(float x, float z)
    {
        this.transform.position += new Vector3(x, 0, z);
    }

    public void Reset()
    {
        this.transform.position = Vector3.zero;
    }
}
