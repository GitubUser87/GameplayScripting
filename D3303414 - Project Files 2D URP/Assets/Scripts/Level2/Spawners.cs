using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    public GameObject Asteroids;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float TimeBetweenSpawn;
    private float SpawnTime;

    

    private void Update()
    {
        if (Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }
    }

    void Spawn()
    {
        //This will pick a random float from the values that have been entered.
        float X = Random.Range(minX, maxY);
        float Y = Random.Range(minY, maxX);
        //This will then spawn the object at one of the selected floats.
        Instantiate(Asteroids, transform.position + new Vector3(X, Y, 0), transform.rotation);
    }
}
