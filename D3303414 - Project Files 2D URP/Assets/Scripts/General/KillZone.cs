using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    //This code is designed to kill the player in case they fall into the void.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            
            //Will find the audio and play the sound that has that name attached to it.
            FindObjectOfType<AudioManager>().Play("DeathSound");
            if (other.TryGetComponent<PlayerLives>(out PlayerLives playerlives))
            {
                playerlives.Hit();
                
            }
            else
            {
                Destroy(other);
            }

        }
    }
}
