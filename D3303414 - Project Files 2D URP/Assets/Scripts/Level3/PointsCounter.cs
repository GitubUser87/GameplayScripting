using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsCounter : MonoBehaviour
{
  public static PointsCounter Instance;

    public TMP_Text pointsText;
    public int currentPoints = 0;
    
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        pointsText.text = "Points: " + currentPoints.ToString();
    }

    public void IncreasePoints(int v)
    {
        currentPoints += v;
        pointsText.text = "Points: " + currentPoints.ToString();
    }
   
}
