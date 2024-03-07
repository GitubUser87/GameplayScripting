using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesCounter : MonoBehaviour
{
    public static LivesCounter Instance;

    public TMP_Text livesText;

    private PlayerLives playerlives;
    private void Awake()
    {
        Instance = this;

    }
    void Start()
    {
        //This will find the player lives and the store that as a variable.
        playerlives = FindFirstObjectByType<PlayerLives>();
        
    }

   
    void Update()
    {
        //This will present the player's lives as a text string.
        livesText.text = "Lives: " + playerlives.lives.ToString();
    }
}
