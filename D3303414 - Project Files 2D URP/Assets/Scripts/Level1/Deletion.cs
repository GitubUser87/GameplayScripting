using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deletion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Asteroid")
        {
            //If the other tag is the asteroid then it will destroy the asteroid.
            Destroy(other.gameObject);
        }
    }
}
