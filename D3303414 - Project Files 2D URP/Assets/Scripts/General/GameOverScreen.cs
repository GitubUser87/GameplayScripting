using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

public void Restart()
    {
        SceneManager.LoadScene("Menu");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
