using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPoints : MonoBehaviour
{
    int score = 0;
    public Text MyscoreText;
    public void AddScore(int toaddscore)
    {
        score += toaddscore;
        MyscoreText.text = "Score : " + score;
    }
   
}
