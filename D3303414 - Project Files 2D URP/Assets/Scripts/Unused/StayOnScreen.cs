using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnScreen : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.5f, 8.5f), Mathf.Clamp(transform.position.y, -4.5f, 4.5f), transform.position.z);
        //This will make it so that the camera will follow the player at all times.
    }
}
