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
        }
    }

    void spawn()
    {
        float X = Random.Range(minX, maxY);
        float Y = Random.Range(minY, maxX);

        Instantiate(Obstacle, transform.position + new Vector3(X, Y, 0), transform.rotation);
    }
}
