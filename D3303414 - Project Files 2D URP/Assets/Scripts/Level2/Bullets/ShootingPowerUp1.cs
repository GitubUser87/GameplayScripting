using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPowerUp1 : MonoBehaviour
{

    bool equipped = false;
    public static bool fullyUpgraded = false;

    private void Start()
    {
        if (equipped == false)
        {
            Destroy(gameObject, 8);
        }

        if (fullyUpgraded == true) 
        {
            Destroy(gameObject);
            //This prevents the object from spawning if the player has both upgrades equipped.
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            equipped = true;
            //This makes sure the upgrade won't delete whilst the player has it equipped.
            FindObjectOfType<AudioManager>().Play("HealthPickup");
            if(other.TryGetComponent<Shooting>(out Shooting shooting))
            {
                if (shooting.doubleShot == true)
                {
                    shooting.doubleShot = false;
                    shooting.tripleShot = true;
                    fullyUpgraded = true;

                    //This will set the triple shot to true and the double shot to false, as well as setting fully upgraded totrue so that the upgrade won't spawn anymore.
                }
                else 
                {
                    shooting.doubleShot = true;
                    //This will set the double shot to true.
                }
                

            }
            Destroy(gameObject);
        }
    }
}
