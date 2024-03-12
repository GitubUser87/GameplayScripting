using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float move;
    public float speed;
    public GameObject Pause;
    public float jump;

    private bool isjumping;

    private Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    Animator animator;
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
        if (Input.GetButtonDown("Jump") && !isjumping)
        {
            animator.SetBool("IsJumping?", true);
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isjumping = true;
            //Will find the audio and play the sound that has that name attached to it.
            FindObjectOfType<AudioManager>().Play("PlayerJump");   
        }

        if (move > 0)
        {
            spriteRenderer.flipX = false;
        }
        if (move < 0)
        {
            spriteRenderer.flipX = true;
        }
        //This will flip the sprite depending on which direction the player is moving.
        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause.SetActive(true);
            Time.timeScale = 0f;
        }

    }
    //Will make sure the player can't jump unless they have touched the ground again.
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
           foreach (var contact in other.contacts) 
           {
                //This will make it so that the contact point wasn't greater than 0.7.
                if (contact.normal.y > 0.7f)
                {
                    //This will set it so that when the player touches anything with the ground tag they will be allowed to jump again.
                    isjumping = false;
                animator.SetBool("IsJumping?", false);

            }
        }
            
        }
    }
}
