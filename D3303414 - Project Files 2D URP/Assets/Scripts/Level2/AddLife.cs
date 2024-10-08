using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLife : MonoBehaviour
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
            if (other.TryGetComponent<PlayerLives>(out PlayerLives playerlives))
            {
                FindObjectOfType<AudioManager>().Play("HealthPickup");
                playerlives.Heal();
                Destroy(gameObject);
            }
        }
    }
}
