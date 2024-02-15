using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerControls3 : MonoBehaviour
{
    public float move;
    public float power = 4f;
    public float health = 3f;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
       
        move = Input.GetAxisRaw("Horizontal");
        //This locks the movement to horizontal only.
       
        if (Input.GetButtonDown("Jump"))
        {
            //This will only allow the player to move if the jump button has been pressed at the same time.
            rb.velocity = new Vector2(move * power, rb.velocity.y);
            FindObjectOfType<AudioManager>().Play("DashSound");
        }
   
      
    }
    public void Damage()
    {
       // FindObjectOfType<AudioManager>().Play("DeathSound");
       // Destroy(other.gameObject);
    }
    }
