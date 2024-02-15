using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform platform;
    public Transform startPoint, endPoint;
    
    public int Speed;
    Vector2 targetPos;

    private void Start()
    {
        targetPos = endPoint.position;
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, startPoint.position) < .1f) targetPos = endPoint.position;

        if (Vector2.Distance(transform.position, endPoint.position) < .1f) targetPos = startPoint.position;

        transform.position = Vector2.MoveTowards(transform.position, targetPos, Speed * Time.deltaTime);
    }




}
