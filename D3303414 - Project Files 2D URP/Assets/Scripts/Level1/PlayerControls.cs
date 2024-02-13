using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float move;
    public float speed;
    public float jump;

    private bool isjumping;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump") && !isjumping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isjumping = true;
            //Will find the audio and play the sound that has that name attached to it.
            FindObjectOfType<AudioManager>().Play("PlayerJump");
        }

    }
    //Will make sure the player can't jump unless they have touched the ground again.
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            //This will set it so that when the player touches anything with the ground tag they will be allowed to jump again.
            isjumping = false;
        }
    }
}
