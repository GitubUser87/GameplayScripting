using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    public UnityEvent OnTouched = new UnityEvent();
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            OnTouched.Invoke(); 
            Destroy(gameObject);
        }

        if (other.tag == "Player")
        {
           Destroy(other.gameObject);    
        }
    }
}
