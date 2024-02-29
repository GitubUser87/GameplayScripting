using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsControls : MonoBehaviour
{
    public void ChangeVolume(float volume)
    {
        AudioListener.volume = volume;
    }

    public void Sound()
    {
        FindObjectOfType<AudioManager>().Play("SettingsMenu");
    }
}
