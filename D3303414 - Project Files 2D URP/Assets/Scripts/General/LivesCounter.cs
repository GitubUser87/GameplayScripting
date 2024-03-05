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
        playerlives = FindFirstObjectByType<PlayerLives>();
        
    }

   
    void Update()
    {
        livesText.text = "Lives: " + playerlives.lives.ToString();
    }
}
