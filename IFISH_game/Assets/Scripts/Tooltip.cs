using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
    public GameObject box;
    public Text textBox;
    public string dialog;
    public bool playerInRange;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange)
        {
            if (box.activeInHierarchy)
            {
                box.SetActive(false);
            }
            else
            {
                box.SetActive(true);
                textBox.text = dialog;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            box.SetActive(false);
        }
    }
}
