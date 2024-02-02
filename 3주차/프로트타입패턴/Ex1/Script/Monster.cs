using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public virtual Monster clone()
    {
        return this;
    }
}
