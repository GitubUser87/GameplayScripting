using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZoneLevel1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //this will kill the player if they touch it.
            FindObjectOfType<AudioManager>().Play("DeathSound");
            Destroy(other.gameObject);
        }
    }
}
