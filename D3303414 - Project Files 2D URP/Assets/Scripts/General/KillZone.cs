using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    [SerializeField] GameObject Death;
    //This code is designed to kill the player in case they fall into the void.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            
            //Will find the audio and play the sound that has that name attached to it.
            FindObjectOfType<AudioManager>().Play("DeathSound");
            if (other.TryGetComponent<PlayerLivesLevel1>(out PlayerLivesLevel1 playerlives))
            {
                playerlives.Hit();
                GameObject Boom = Instantiate(Death, transform.position, transform.rotation);
                Destroy(Boom, 0.75f);

            }
            else
            {
                Destroy(other);
            }

        }
    }
}
