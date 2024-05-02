using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    //This code will cause the asteroids to move in random directions.
    [SerializeField]
    float speed;
    [SerializeField]
    float range;
    [SerializeField]
    float maxDistance;

    Vector2 wayPoint;
    void Start()
    {
        SetNewDestination();
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, wayPoint) < range)
        {
            SetNewDestination();
        }
    }

    void SetNewDestination()
    {
        //This will pick a random range between the max distances and set it as the new coordinates.
        wayPoint = new Vector2(Random.Range( -maxDistance, maxDistance), Random.Range( -maxDistance, maxDistance));
    }
}
