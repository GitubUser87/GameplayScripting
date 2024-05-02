using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrapForAsteroids : MonoBehaviour
{

    float leftConstraint = Screen.width;
    float rightConstraint = Screen.width;
    float bottomConstraint = Screen.height;
    float topConstraint = Screen.height;
    float buffer = 1.0f;
    Camera cam;
    float distanceZ;
    TrailRenderer trail;
    void Start()
    {
        trail = GetComponent<TrailRenderer>();
        //This will allow the Asteroids in level 2 to stay on screen and float around the level.
        cam = Camera.main;
        distanceZ = Mathf.Abs(cam.transform.position.z + transform.position.z);
        leftConstraint = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distanceZ)).x;
        rightConstraint = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, distanceZ)).x;
        bottomConstraint = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distanceZ)).y;
        topConstraint = cam.ScreenToWorldPoint(new Vector3(0.0f, Screen.height, distanceZ)).y;
        
    }

    void Update() //This will detect if the object has reached these coordinates and will then set them to the new ones, it will also clear any trail effects.
    {

        if (transform.position.x < leftConstraint - buffer)
        {
            transform.position = new Vector3(rightConstraint - 0.10f, transform.position.y, transform.position.z);
            if (trail != null)
            {
                trail.Clear();
            }
        }
        if (transform.position.x > rightConstraint)
        {
            transform.position = new Vector3(leftConstraint, transform.position.y, transform.position.z);
            if (trail != null)
            {
                trail.Clear();
            }
        }
        if (transform.position.y < bottomConstraint - buffer)
        {
            transform.position = new Vector3(transform.position.x, topConstraint + buffer, transform.position.z);
            if (trail != null)
            {
                trail.Clear();
            }
        }
        if (transform.position.y > topConstraint + buffer)
        {
            transform.position = new Vector3(transform.position.x, bottomConstraint - buffer, transform.position.z);
            if (trail != null)
            {
                trail.Clear();
            }
        }
    }
}
