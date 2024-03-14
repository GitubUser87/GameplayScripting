using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSmallerAsteroid : MonoBehaviour
{

    public GameObject Smallerasteroid;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            Instantiate(Smallerasteroid);
        }
    }
}
