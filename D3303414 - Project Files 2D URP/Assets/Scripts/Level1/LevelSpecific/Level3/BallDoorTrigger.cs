using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDoorTrigger : MonoBehaviour
{
    public GameObject Ball;
    public GameObject BallDoor;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Trigger")
        {
            
            BallDoor.SetActive(false);
            FindAnyObjectByType<AudioManager>().Play("ButtonSound");
        }
       
    }
}
