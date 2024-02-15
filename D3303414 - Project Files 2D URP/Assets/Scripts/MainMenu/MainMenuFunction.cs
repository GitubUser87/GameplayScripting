using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    public void playGame1()
    {
        //This code is designed to load up Game 1.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void playGame2()
    {
        //This code is designed to load up Game 2.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void playGame3()
    {
        //This code is designed to load up Game 3.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void QuitGame()
    {
        //This code is designed to quit the project.
        Application.Quit();
    }
}
