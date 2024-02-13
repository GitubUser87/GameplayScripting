using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Will find the audio and play the sound that has that name attached to it.
            FindObjectOfType<AudioManager>().Play("DeathSound");
            Destroy(other.gameObject);
        }
            
    }
}
