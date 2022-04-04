using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layerSwitching : MonoBehaviour
{

    public Transform obj;
    public Transform player;
    public SpriteRenderer objR;
    public float offset;


    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
       if(obj.position.y < player.position.y + offset )
       {
            objR.sortingLayerName = "ObjectsBelow";
       }
       if(obj.position.y > player.position.y + offset )
       {
            objR.sortingLayerName = "ObjectsAbove";
       }
    }
}
