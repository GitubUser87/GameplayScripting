using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{

    float leftConstraint = Screen.width;
    float rightConstraint = Screen.height;
    float buffer = 1.0f;
    Camera cam;
    float distanceZ;
    void Start()
    {
        cam = Camera.main;
        distanceZ = Mathf.Abs(cam.transform.position.z + transform.position.z);
        leftConstraint = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distanceZ)).x;
        rightConstraint = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, distanceZ)).x;
    }

    void Update()
    {
        if(transform.position.x < leftConstraint - buffer)
        {
            transform.position = new Vector3(rightConstraint - 0.10f, transform.position.y, transform.position.z);
        }
        if (transform.position.x > rightConstraint)
        {
            transform.position = new Vector3(leftConstraint, transform.position.y, transform.position.z);
        }
    }
}
