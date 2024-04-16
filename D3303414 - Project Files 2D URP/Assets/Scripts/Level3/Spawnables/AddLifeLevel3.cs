using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLifeLevel3 : MonoBehaviour
{
    public int destruction;
    private void Start()
    {
        Destroy(gameObject, destruction);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (other.TryGetComponent<PlayerLivesLevel3>(out PlayerLivesLevel3 playerlives))
            {
                FindObjectOfType<AudioManager>().Play("HealthPickup");
                playerlives.Heal();
                Destroy(gameObject);
            }
        }
    }
}
