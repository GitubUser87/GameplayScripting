using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
   
    private void Start()
    {
        Destroy(gameObject,2);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            
                //Damage();
                //Will find the audio and play the sound that has that name attached to it.
                FindObjectOfType<AudioManager>().Play("DeathSound");
                if (other.TryGetComponent<PlayerLives>(out PlayerLives playerlives))
                {
               
                    if (!playerlives.hasShield) 
                    {
                    playerlives.Hit();
                    Destroy(gameObject);
                    }
                }
            
        }
            
    }
}
