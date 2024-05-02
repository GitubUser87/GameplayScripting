using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float life = 1;
    public CameraShake cameraShake;
    void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //When the bullet collides it will be destroyed.
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.tag == "Asteroid")
        {
            
            Destroy(gameObject);
            //This will destroy the bullet so that it won't go on forever.
        }
    }
}
