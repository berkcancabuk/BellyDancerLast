using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rig : MonoBehaviour
{
    public GameObject Character;
    public BoolConts boolean;
    
    void Update()
    {
        if (boolean.CircleTrigger == false)
        {
            this.transform.position = Character.transform.position;
        }
       
    }
}
