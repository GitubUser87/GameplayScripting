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
        }
    }

    void Spawn()
    {
        Instantiate(Asteroid, transform.position, transform.rotation);
    }
}
