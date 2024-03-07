using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsControls : MonoBehaviour
{
    public void ChangeVolume(float volume)
    {

        //This will allow the slider to change the games volume.
        AudioListener.volume = volume;
    }

    public void Sound()
    {
        //This will play the sound that has been entered.
        FindObjectOfType<AudioManager>().Play("SettingsMenu");
    }
}
