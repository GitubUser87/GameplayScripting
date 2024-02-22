using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLife : MonoBehaviour
{

    private void Start()
    {
        Destroy(gameObject, 3);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (other.TryGetComponent<PlayerLives>(out PlayerLives playerlives))
            {
                playerlives.Heal();
                Destroy(gameObject);
            }
        }
    }
}
