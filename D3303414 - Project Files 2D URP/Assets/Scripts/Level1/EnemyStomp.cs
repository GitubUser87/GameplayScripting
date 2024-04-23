using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStomp : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EnemyKill"))
        {
            FindObjectOfType<AudioManager>().Play("Stomp");
            Destroy(other.gameObject);
        }
    }

}
