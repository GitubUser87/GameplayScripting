using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerControls3 : MonoBehaviour
{
    public float move;
    public float power = 4f;
 
    

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }


    void Update()
    {
       
        move = Input.GetAxisRaw("Horizontal");
       
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(move * power, rb.velocity.y);
            FindObjectOfType<AudioManager>().Play("DashSound");
        }
   
      
    }
    }
