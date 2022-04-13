using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame : MonoBehaviour
{
    public GameObject castingBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D( Collider2D player )
    {
        if (player.CompareTag("Player"))
        {
            castingBar.transform.localPosition = new Vector2(-1.5f, 0f);
            castingBar.SetActive(true);
        }
    }

    void OnTriggerExit2D( Collider2D player )
    {
        if (player.CompareTag("Player"))
        {
            castingBar.SetActive(false);
        }
    }
}
