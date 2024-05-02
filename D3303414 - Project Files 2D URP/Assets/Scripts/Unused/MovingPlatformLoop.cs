using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovingPlatformLoop : MonoBehaviour
{
    public Transform platform;
    public Transform startPoint, endPoint;

    public int Speed;
    Vector2 targetPos;

    private void Start()
    {
        targetPos = endPoint.position;
        //This will set where the platform is set to move.
    }

    private void Update()
    {
        //This will call the platform and have it move to the transform labelled as endPoint.
        if (Vector2.Distance(transform.position, startPoint.position) < .1f) targetPos = endPoint.position;

        transform.position = Vector2.MoveTowards(transform.position, targetPos, Speed * Time.deltaTime);

    }
}

