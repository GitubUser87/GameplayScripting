using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
   

    public float move;
    public float speed;
    public GameObject Pause;
    public float jump;

    bool doubleJump = true;
    private bool isjumping;
    private float coyoteTime = 0.2f;
    private float coyoteTimeCounter;
    private Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    Animator animator;

    //This will allow the player to perform actions such as walk, jump, double jump.

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
        //This will make it so that unless both of the requirements have been met then the code below won't function.
        if (Input.GetButtonDown("Jump"))
        {
           if (coyoteTimeCounter > 0)
            {

            isjumping = true;
            }
            else if (doubleJump)
            {
                jump = 8;
                isjumping = true;
                doubleJump = false;

            }
        }


        //This will flip the sprite depending on which direction the player is moving.
        if (move > 0)
        {
            spriteRenderer.flipX = false;
        }
        if (move < 0)
        {
            spriteRenderer.flipX = true;
        }
        
        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        //This will open the pause menu when the player presses the correct button.
        if (Input.GetButtonDown("Pause"))
        {
            Pause.SetActive(true);
            Time.timeScale = 0f;
        }
        coyoteTimeCounter -= Time.deltaTime;
        
    }
    //Will make sure the player can't jump unless they have touched the ground again.
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground") && rb.velocity.y <= 0 )
        {
           foreach (var contact in other.contacts) 
           {
                //This will make it so that the contact point wasn't greater than 0.7.
                if (contact.normal.y > 0.7f)
                {
                    //This will set it so that when the player touches anything with the ground tag they will be allowed to jump again.
                   
                    coyoteTimeCounter = coyoteTime;
                    doubleJump = true;
                    animator.SetBool("IsJumping?", false);

                }
                else if (contact.normal.y < 0.7f)
                {
                    doubleJump = false;
                }
                
        }
            
        }
    }
    private void FixedUpdate()
    {
        if (isjumping)
        {
            animator.SetBool("IsJumping?", true);
            rb.velocity = new Vector2(rb.velocity.x, jump);
            isjumping = false;
            jump = 13;
            coyoteTimeCounter = 0;
            //Will find the audio and play the sound that has that name attached to it.
            FindObjectOfType<AudioManager>().Play("PlayerJump");
        }
        
    
    }
}
