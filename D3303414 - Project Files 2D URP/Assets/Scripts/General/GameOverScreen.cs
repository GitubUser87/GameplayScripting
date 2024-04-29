using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public string Level;
    public string nextLevel;

    public static GameOverScreen Instance;

    private void Start()
    {
        Instance = this;
        gameObject.SetActive(false);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
        Time.timeScale = 1f;
    }
    public void Restart()
    {
        SceneManager.LoadScene(Level);
        Time.timeScale = 1f;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
