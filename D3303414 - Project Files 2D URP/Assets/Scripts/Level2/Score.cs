using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum;

    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "Score : " + ScoreNum;
    }

    private void OnTriggerEnter2D(Collider2D Asteroid)
    {
        if (Asteroid.tag == "Asteroid")
        {
            ScoreNum += 1;
            MyscoreText.text = "Score : " + ScoreNum;
        }
    }
}
