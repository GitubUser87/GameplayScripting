using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score;

    void Start()
    {
        score = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Asteroid")
        {
            score += 1;
            print(score);
        }
    }
}
