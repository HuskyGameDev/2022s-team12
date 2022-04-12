using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //variables
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    void Start()
    {
        gameObject.tag = "Player";
    }

    // Update is called once per frame
    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical",   movement.y);
        animator.SetFloat("Speed",      movement.sqrMagnitude);
    }

    //called a number of times per second
    void FixedUpdate()
    {
        
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Main_Menu"))
        {
            return;
        }
        //movement
        Vector2 temp = rb.position + movement * moveSpeed * Time.fixedDeltaTime;
        if( (rb.position.x + temp.x < 15) && (rb.position.x + temp.x > -32.7) && (rb.position.y + temp.y < 16) && (rb.position.y + temp.y > -13.6) )
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
