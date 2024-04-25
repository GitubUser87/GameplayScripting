using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStomp : MonoBehaviour
{
    [SerializeField] GameObject Death;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EnemyKill"))
        {
            FindObjectOfType<AudioManager>().Play("Stomp");
            Destroy(other.gameObject);
            GameObject Boom = Instantiate(Death, transform.position, transform.rotation);
            Destroy(Boom, 0.75f);
        }
    }

}
