using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] GameObject Death;
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
                if (other.TryGetComponent<PlayerLivesLevel3>(out PlayerLivesLevel3 playerlives))
                {
               
                    if (!playerlives.hasShield) 
                    {
                    playerlives.Hit();
                    Destroy(gameObject);
                    GameObject Boom = Instantiate(Death, transform.position, transform.rotation);
                    Destroy(Boom, 0.75f);
                }
                }
            
        }
            
    }
}
