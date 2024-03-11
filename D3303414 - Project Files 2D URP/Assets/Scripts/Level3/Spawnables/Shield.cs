using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject sheild;
    bool equipped = false;
    private void Start()
    {
        if (equipped == false)
        {
            Destroy(gameObject, 4);
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            equipped = true;
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
