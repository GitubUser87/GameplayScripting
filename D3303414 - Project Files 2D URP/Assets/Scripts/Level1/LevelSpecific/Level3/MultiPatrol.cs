using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiPatrol : MonoBehaviour
{
    public float speed = 1f;
    public Vector2[] waypoints;

    Rigidbody2D body;
    int wayPointIndex = 0;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        transform.position = waypoints[0];
    }

    private void FixedUpdate()
    {
        Vector2 newPosition = Vector2.MoveTowards(body.position, waypoints[wayPointIndex], speed);
        body.MovePosition(newPosition);
        if (Vector2.Distance(newPosition, waypoints[wayPointIndex]) < 0.1f)
        {
            wayPointIndex = (wayPointIndex + 1) % waypoints.Length;
        }
    }
        void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
            Vector2 lastPosition = waypoints[0];
            foreach(Vector2 waypoint in waypoints)
            {
                Gizmos.DrawLine(lastPosition, waypoint);
                Gizmos.DrawSphere(waypoint, 0.3f);
                lastPosition = waypoint;
            }
    }
}

