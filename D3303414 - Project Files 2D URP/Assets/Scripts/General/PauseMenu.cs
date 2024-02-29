using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public void Pause()
    {
        //Will find the audio and play the sound that has that name attached to it.
        FindObjectOfType<AudioManager>().Play("MenuSound");
        pauseMenu.SetActive(true);
         Time.timeScale = 0f;
         //This will pause the game.
    }

    
    public void Resume()
    {
        //Will find the audio and play the sound that has that name attached to it.
        FindObjectOfType<AudioManager>().Play("MenuSound");
        pauseMenu.SetActive(false); 
        Time.timeScale = 1f;
        //This will set the game back into motion.
    }

    public void Sound()
    {
        FindObjectOfType<AudioManager>().Play("MenuSound");
    }

    public void Quit(int sceneID)
    {
        //Will find the audio and play the sound that has that name attached to it.
        FindObjectOfType<AudioManager>().Play("MenuSound");
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
        //This will load up the scene ID that has been entered.
    }

    public void ChangeVolume (float volume)
    {
        AudioListener.volume = volume;
    }
}
