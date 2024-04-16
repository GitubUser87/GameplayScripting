using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesCounterLevel3 : MonoBehaviour
{
    public static LivesCounterLevel3 Instance;

    public TMP_Text livesText;

    private PlayerLivesLevel3 playerlives;
    private void Awake()
    {
        Instance = this;

    }
    void Start()
    {
        //This will find the player lives and the store that as a variable.
        playerlives = FindFirstObjectByType<PlayerLivesLevel3>();

    }


    void Update()
    {
        //This will present the player's lives as a text string.
        livesText.text = "Lives: " + playerlives.lives.ToString();
    }
}
