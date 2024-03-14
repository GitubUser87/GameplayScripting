using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusLife : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (other.TryGetComponent<PlayerLivesLevel1>(out PlayerLivesLevel1 playerlivesLevel1))
            {
                FindObjectOfType<AudioManager>().Play("HealthPickup");
                playerlivesLevel1.Heal();
                Destroy(gameObject);
            }
        }
    }
   

}
