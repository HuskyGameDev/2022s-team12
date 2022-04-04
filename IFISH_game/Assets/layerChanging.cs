using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layerSwitching : MonoBehaviour
{

    public Transform obj;
    public Transform player;


    // Update is called once per frame

    void FixedUpdate()
    {
       if(obj.position.y < player.position.y)
        {

        }
    }
}
