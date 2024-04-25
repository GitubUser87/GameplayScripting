using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullets : MonoBehaviour
{
    public float life = 1;
    [SerializeField] GameObject Death;

    private void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("DeathSound");
            if (other.TryGetComponent<PlayerLives>(out PlayerLives playerlives))
            {
                playerlives.Hit();
                GameObject Boom = Instantiate(Death, transform.position, transform.rotation);
                Destroy(Boom, 0.75f);
            }
            Destroy(gameObject);
        }
    }
}
