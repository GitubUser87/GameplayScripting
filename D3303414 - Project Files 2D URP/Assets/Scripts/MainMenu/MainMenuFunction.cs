using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    
    public void playGame1()
    {
        FindObjectOfType<AudioManager>().Play("MenuSound");
        //This code is designed to load up Game 1.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void playLevel2()
    {
        FindObjectOfType<AudioManager>().Play("MenuSound");
        //This code is designed to load up Game 1.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void playLevel3()
    {
        FindObjectOfType<AudioManager>().Play("MenuSound");
        //This code is designed to load up Game 1.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    
    public void playGame2()
    {
        FindObjectOfType<AudioManager>().Play("MenuSound");
        //This code is designed to load up Game 2.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void playGame3()
    {
        FindObjectOfType<AudioManager>().Play("MenuSound");
        //This code is designed to load up Game 3.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }

    public void QuitGame()
    {
        FindObjectOfType<AudioManager>().Play("MenuSound");
        //This code is designed to quit the project.
        Application.Quit();
    }

    public void Sound()
    {
        //This will play the sound selected.
        FindObjectOfType<AudioManager>().Play("MenuSound");
    }
   
}
