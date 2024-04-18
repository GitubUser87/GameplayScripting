using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectiveTrigger : MonoBehaviour
{
    public TextMeshProUGUI ObjectiveText;
    public string Objective;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

           
            ObjectiveText.text = Objective;
            FindAnyObjectByType<AudioManager>().Play("ButtonSound");
        }
    }
}
