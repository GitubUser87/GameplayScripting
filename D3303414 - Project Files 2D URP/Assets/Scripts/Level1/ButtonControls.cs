using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonControls : MonoBehaviour
{
    public GameObject door;
    public GameObject button;
    public TextMeshProUGUI ObjectiveText;
    public string Objective;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //This will make it so that the button can't be triggered twice and the door will disappear.
            door.SetActive(false);
            button.SetActive(false);
            //Will find the audio and play the sound that has that name attached to it.
            FindObjectOfType<AudioManager>().Play("ButtonSound");
            ObjectiveText.text = Objective;

        }
        else
        {
            //This will make it so that the door will stay closed until the button is pressed.
            door.SetActive(true);
        }
    }


}
