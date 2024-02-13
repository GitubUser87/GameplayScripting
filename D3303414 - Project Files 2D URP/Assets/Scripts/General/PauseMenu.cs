using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        //This will pause the game.
    }

    
    public void Resume()
    {
        pauseMenu.SetActive(false); 
        Time.timeScale = 1f;
        //This will set the game back into motion.
    }

    public void Quit(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
        //This will load up the scene ID that has been entered.
    }
}
