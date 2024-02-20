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
    public AddPoints addPoints; //k change

    private void Start()
    {
        addPoints = GetComponent<AddPoints>(); //Getting access to other script Kyle change
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            OnTouched.Invoke();
            //Will find the audio and play the sound that has that name attached to it.
            FindObjectOfType<AudioManager>().Play("AsteroidDestruction");
            addPoints.AddScore(5); //Adding score to script Kyle change
            Destroy(gameObject);
            SpawnNextCircle();

        }

        if (other.tag == "Player")
        {
           //Will find the audio and play the sound that has that name attached to it.
           FindObjectOfType<AudioManager>().Play("DeathSound");
            if (other.TryGetComponent<PlayerLives>(out PlayerLives playerlives))
            {
                playerlives.Hit();
            }
        }
    }

    public void SpawnNextCircle()
    {

    }
}
