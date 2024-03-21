using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerControl2 : MonoBehaviour
{

    public float maxSpeed = 5f;
    public float rotSpeed = 720f;
    public GameObject Pause;
    void Update()
    {

        
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z -= Input.GetAxis("HorizontalRight") * rotSpeed * Time.deltaTime;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;
       
        Vector3 pos = transform.position;
        //pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
        //pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;
        //transform.position = pos;

        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);
        pos += rot * velocity;
        GetComponent<AudioSource>().volume = Mathf.Min(1,velocity.magnitude/Time.deltaTime);
        
        
        transform.position = pos;
        if (Input.GetButtonDown("Pause"))
        {
            Pause.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
