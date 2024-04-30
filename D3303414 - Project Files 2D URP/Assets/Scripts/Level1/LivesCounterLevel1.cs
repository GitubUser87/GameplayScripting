using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//This is specifically designed for Level 1.
public class LivesCounterLevel1 : MonoBehaviour
{
    public static LivesCounterLevel1 Instance;

    public TMP_Text livesText;
    //This will display the amount of lives the player has on screen.
    private PlayerLivesLevel1 playerlives;
    private void Awake()
    {
        Instance = this;

    }
    void Start()
    {
        //This will find the player lives and the store that as a variable.
        playerlives = FindFirstObjectByType<PlayerLivesLevel1>();

    }


    void Update()
    {
        //This will present the player's lives as a text string.
        livesText.text = "Lives: " + playerlives.lives.ToString();
    }
}
