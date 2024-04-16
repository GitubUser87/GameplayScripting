using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPowerUp1 : MonoBehaviour
{

    bool equipped = false;
   public bool fullyUpgraded = false;

    private void Start()
    {
        if (equipped == false)
        {
            Destroy(gameObject, 8);
        }

        if (fullyUpgraded == true) 
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            equipped = true;
            FindObjectOfType<AudioManager>().Play("HealthPickup");
            if(other.TryGetComponent<Shooting>(out Shooting shooting))
            {
                if (shooting.doubleShot == true)
                {
                    shooting.doubleShot = false;
                    shooting.tripleShot = true;
                    fullyUpgraded = true;
                }
                else 
                {
                    shooting.doubleShot = true;
                }
                

            }
            Destroy(gameObject);
        }
    }
}
