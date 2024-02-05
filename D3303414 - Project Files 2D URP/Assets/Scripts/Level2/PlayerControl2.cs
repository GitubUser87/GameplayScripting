using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerControl2 : MonoBehaviour
{

    public float maxSpeed = 5f;
    public float rotSpeed = 360f;

    void Update()
    {
        

        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;

        Vector3 pos = transform.position;
        //pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
        //pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;
        //transform.position = pos;

        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);
        pos += rot * velocity;

        transform.position = pos;
    }
}
