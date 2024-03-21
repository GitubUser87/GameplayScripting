using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenReveal : MonoBehaviour
{
    public GameObject hidden;
    public GameObject button;
    public GameObject Hint;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //This will make it so that the button can't be triggered twice and the door will disappear.
            hidden.SetActive(true);
            button.SetActive(false);
            Hint.SetActive(false);
            //Will find the audio and play the sound that has that name attached to it.
            FindObjectOfType<AudioManager>().Play("ButtonSound");
        }
        else
        {
            //This will make it so that the door will stay closed until the button is pressed.
            hidden.SetActive(false);
        }
    }
}
