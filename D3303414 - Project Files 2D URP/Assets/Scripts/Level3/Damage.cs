using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Damage();
            //Will find the audio and play the sound that has that name attached to it.
            FindObjectOfType<AudioManager>().Play("DeathSound");
            if (other.TryGetComponent<PlayerLives>(out PlayerLives playerlives))
            {
                playerlives.Hit();
                Destroy(gameObject);
            }
        }
            
    }
}
