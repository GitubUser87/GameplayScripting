using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public string Level;
    public static GameOverScreen Instance;

    private void Start()
    {
        Instance = this;
        gameObject.SetActive(false);
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
