using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
 
    public GameObject Obstacle;
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
            spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
            //This will delay the spawn between each round as to not lag the machine or make it impossible to play.
        }
    }

    void spawn()
    {
        //This will pick a random float from the values that have been entered.
        float X = Random.Range(minX, maxX);
        float Y = Random.Range(minY, maxY);
        //This will then spawn the object at one of the selected floats.
        Instantiate(Obstacle, transform.position + new Vector3(X, Y, 0), transform.rotation);
    }
}
