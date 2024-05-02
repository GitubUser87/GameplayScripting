using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;



public class Score : MonoBehaviour
{
    public int ScoreValue = 0;
    [SerializeField] GameObject Death;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            //Will find the audio and play the sound that has that name attached to it.
            FindObjectOfType<AudioManager>().Play("AsteroidDestruction");
            FindFirstObjectByType<AddPoints>().AddScore(ScoreValue);
            FindFirstObjectByType<CameraShake>().ShakeCamera();
            Destroy(gameObject);
            GameObject Boom = Instantiate(Death, transform.position, transform.rotation);
            Destroy(Boom, 0.75f);
        }

        if (other.tag == "Player")
        {
           //Will find the audio and play the sound that has that name attached to it.
           FindObjectOfType<AudioManager>().Play("DeathSound");
            if (other.TryGetComponent<PlayerLives>(out PlayerLives playerlives))
            {
                playerlives.Hit();
                GameObject Boom = Instantiate(Death, transform.position, transform.rotation);
                Destroy(Boom, 0.75f);
            }
        }
    }

   
}
