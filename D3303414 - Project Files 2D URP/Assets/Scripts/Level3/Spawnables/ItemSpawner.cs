using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    ////This will pick a random float from the values that have been entered.
    //float X = Range(X, X);
    //float Y = Range(Y, Y);
    public GameObject Obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;

    public float TimeBetweenSpawn;
    private float SpawnTime;

    private void Start()
    {
        SpawnTime = Time.time + TimeBetweenSpawn;
    }

    private void Update()
    {
        if (Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
            //This will delay the spawn between each round as to not lag the machine or make it impossible to play.
        }
    }

    void Spawn()
    {
        //This will pick a random float from the values that have been entered.
        float X = Random.Range(minX, maxX);
        float Y = Random.Range(minY, maxY);
        //This will then spawn the object at one of the selected floats.
        var It = Instantiate(Obstacle, transform.position + new Vector3(X, Y, 0), transform.rotation);
        Destroy(It, 5);
    }
}
