using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float life = 1;

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
    }
}
