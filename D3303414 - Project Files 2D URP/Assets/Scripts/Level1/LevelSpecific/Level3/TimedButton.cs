using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimedButton : MonoBehaviour
{
    public GameObject door;
    public GameObject button;
    public TextMeshProUGUI ObjectiveText;
    public string Objective;
    public string Reset;
    public float Timer = 0f;
    public bool buttonActive = true;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && buttonActive == true)
        {
           
            //This will make it so that the button can't be triggered twice and the door will disappear.
            door.SetActive(false);

            //Will find the audio and play the sound that has that name attached to it.
            FindObjectOfType<AudioManager>().Play("ButtonSound");
            ObjectiveText.text = Objective;
            Timer = 20f;
            buttonActive = false;
            
        }
        else
        {
            //This will make it so that the door will stay closed until the button is pressed.
            //door.SetActive(true);
            //button.SetActive(true);

        }
    }
    private void Update()
    {
        if (Timer > 0f)
        {
            Timer -= Time.deltaTime;
        }

        if (Timer <= 0f)
        {
            Timer = 0f;
            door.SetActive(true);
            buttonActive = true;
        }
    }
}
