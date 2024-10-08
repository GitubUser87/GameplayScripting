using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BallDoorTrigger : MonoBehaviour
{
    public GameObject Ball;
    public GameObject BallDoor;
    public TextMeshProUGUI ObjectiveText;
    public string Objective;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Trigger")
        {
            
            BallDoor.SetActive(false);
            ObjectiveText.text = Objective;
            FindAnyObjectByType<AudioManager>().Play("ButtonSound");
        }
       
    }
}
