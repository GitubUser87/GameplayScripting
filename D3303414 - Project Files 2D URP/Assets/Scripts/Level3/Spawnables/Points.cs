using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public int value;
    void Start()
    {
        Destroy(gameObject, 5);
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("PointsEarned");
            Destroy(gameObject);
            PointsCounter.Instance.IncreasePoints(value);
        }
    }
}
