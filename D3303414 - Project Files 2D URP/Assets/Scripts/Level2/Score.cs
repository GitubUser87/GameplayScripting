using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.GameCenter;


public class Score : MonoBehaviour
{
    public UnityEvent OnTouched = new UnityEvent();
 
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            OnTouched.Invoke();
            //Will find the audio and play the sound that has that name attached to it.
            FindObjectOfType<AudioManager>().Play("AsteroidDestruction");
            Destroy(gameObject);
            SpawnNextCircle();

        }

        if (other.tag == "Player")
        {
           Destroy(other.gameObject);    
        }
    }

    public void SpawnNextCircle()
    {

    }
}
