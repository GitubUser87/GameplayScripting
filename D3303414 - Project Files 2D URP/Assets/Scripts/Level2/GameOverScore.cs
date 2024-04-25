using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScore : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    void Update()
    {
        //This will set the final score text as the players score.
        textMeshProUGUI.text = $" Final Score: {FindFirstObjectByType<AddPoints>().score}";
    }
}
