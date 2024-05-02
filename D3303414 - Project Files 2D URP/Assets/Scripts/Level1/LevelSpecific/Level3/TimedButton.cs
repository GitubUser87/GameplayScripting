using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.Universal;
using TMPro;
using UnityEngine;

public class TimedButton : MonoBehaviour
{
    public GameObject door;
    public GameObject button;
    public TextMeshProUGUI ObjectiveText;
    public string Objective;
    public string Reset;
    public float Timer = 0f;
    public bool buttonActive = true;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && buttonActive == true)
        {
           
            //This will make it so that the button can't be triggered twice and the door will disappear.
            door.SetActive(false);

            //Will find the audio and play the sound that has that name attached to it.
            FindObjectOfType<AudioManager>().Play("ButtonSound");
            ObjectiveText.text = Objective;
            Timer = 20f;
            buttonActive = false;
            
        }
        
    }
    private void Update()
    {
        if (Timer > 0f) //When the button has been pressed
        {
            Timer -= Time.deltaTime;
            spriteRenderer.color = new Color(0f, 1f, 0f, 1f);
        }

        if (Timer <= 5f)
        {
            //StartCoroutine("Flickering");
        }

        if (Timer <= 0f)
        {
            Timer = 0f;
            spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
            door.SetActive(true);
            buttonActive = true;
        }

        //IEnumerator Flickering()
        //{
        //    float time = 1f;
        //    while (time > 0)
        //    {
        //        spriteRenderer.color = new Color(1f, 1f, 1f, (Mathf.Sin(time * 50) + 1) * 0.5f);
        //        yield return null;
        //        time = time - Time.deltaTime;
        //    }
        //}
    }

}
