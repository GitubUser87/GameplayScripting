using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusLife : MonoBehaviour
{
    //This will add a life to the player upon being collected.
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (other.TryGetComponent<PlayerLivesLevel1>(out PlayerLivesLevel1 playerlivesLevel1)) //This will search for the player lives in level one and get it if it is found.
            {
                FindObjectOfType<AudioManager>().Play("HealthPickup");
                playerlivesLevel1.Heal(); //This will call the function in PlayerlivesLevel1
                Destroy(gameObject);
            }
        }
    }
   

}
