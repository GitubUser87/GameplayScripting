using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiPatrolPop_Up : MonoBehaviour
{
    public float speed = 1f;
    public Vector2[] waypoints;
    public float TimeBetweenSpawn;
    private float SpawnTime;
    Rigidbody2D body;
    int wayPointIndex = 0;
    bool movementAllowed = false;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        transform.position = waypoints[0];
    }
    private void Update()
    {
        if (Time.time > SpawnTime)
        {

            SpawnTime = Time.time + TimeBetweenSpawn;
            movementAllowed = true;
            //This will delay the spawn between each round as to not lag the machine or make it impossible to play.
        }
    }

    private void FixedUpdate()
    {
        if (movementAllowed)
        {
            Vector2 newPosition = Vector2.MoveTowards(body.position, waypoints[wayPointIndex], speed);
            body.MovePosition(newPosition);
            if (Vector2.Distance(newPosition, waypoints[wayPointIndex]) < 0.1f)
            {
                if (wayPointIndex == 0)
                {
                    movementAllowed = false;
                }
                wayPointIndex = (wayPointIndex + 1) % waypoints.Length;

            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Vector2 lastPosition = waypoints[0];
        foreach (Vector2 waypoint in waypoints)
        {
            Gizmos.DrawLine(lastPosition, waypoint);
            Gizmos.DrawSphere(waypoint, 0.3f);
            lastPosition = waypoint;
        }
    }
}