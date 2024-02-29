using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject sheild;
    private void Start()
    {
        //Destroy(gameObject, 5);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            FindObjectOfType<AudioManager>().Play("HealthPickup");
            Instantiate(sheild);
            if(other.TryGetComponent<PlayerLives>(out PlayerLives playerlives))
            {
                playerlives.hasShield = true;
            }
            Destroy(gameObject);

        }
        
    }
    }
