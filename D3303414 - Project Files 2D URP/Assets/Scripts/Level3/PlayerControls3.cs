using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerControls3 : MonoBehaviour
{
    public float move;
    public float power;
    bool isRunning = false;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if(!isRunning)
        {
            power = 1.0f;
        }
        else
        {
            power = 2.0f;
        }
        
        if (Input.GetButtonDown("Jump") )
        {
            move = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(move * power, rb.velocity.y);
        }
        if (Input.GetButtonDown("Fire3"))
        {
            isRunning = true;
            print("Hello");
        }
        else
        {
            isRunning = false;
        }
    }
    }
