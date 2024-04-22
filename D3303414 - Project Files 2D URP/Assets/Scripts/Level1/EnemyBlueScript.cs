using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlueScript : MonoBehaviour
{
    public Collider2D BoxKiller;
    public Collider2D BoxBlue;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            Destroy(gameObject);
        }
    }
}
