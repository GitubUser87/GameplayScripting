using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    public GameObject Asteroid;
    public float TimeBetweenSpawn;
    private float spawnTime;
    
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + TimeBetweenSpawn;
            //This will call the spawn function as well as make it so that the spawn time resets.
        }
    }

    void Spawn()
    {
        Instantiate(Asteroid, transform.position, transform.rotation);
        //This will create a new asteroid.
    }
}
