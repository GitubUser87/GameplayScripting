using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LivesCounterLevel1 : MonoBehaviour
{
    public static LivesCounterLevel1 Instance;

    public TMP_Text livesText;

    private PlayerLivesLevel1 playerlives;
    private void Awake()
    {
        Instance = this;

    }
    void Start()
    {
        playerlives = FindFirstObjectByType<PlayerLivesLevel1>();

    }


    void Update()
    {
        livesText.text = "Lives: " + playerlives.lives.ToString();
    }
}
