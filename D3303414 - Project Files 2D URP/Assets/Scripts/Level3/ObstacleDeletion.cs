using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDeletion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Asteroid")
        {
            //This will check to see if the asteroid has hit the kill line and delete it. This is done to prevent them falling endlessly.
            Destroy(other.gameObject);
            FindObjectOfType<AudioManager>().Play("AsteroidDeletion");
        }
    }
}
