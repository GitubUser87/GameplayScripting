using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSmallerAsteroid : MonoBehaviour
{

    public GameObject Smallerasteroid;

    //This will spawn in smaller asteroids should the bigger one be destroyed.

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            Instantiate(Smallerasteroid, transform.position, transform.rotation);
            Instantiate(Smallerasteroid, transform.position, transform.rotation);
            Instantiate(Smallerasteroid, transform.position, transform.rotation);
        }
    }
}
