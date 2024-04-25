using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPoints : MonoBehaviour
{
    public int score = 0;
    public Text MyscoreText;
    public void AddScore(int toaddscore)
    {
        //This will add a point to the score for everytime the object is destroyed.
        score += toaddscore;
        MyscoreText.text = "Score : " + score;
    }
   
}
