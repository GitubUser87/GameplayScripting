using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectiveTrigger : MonoBehaviour
{
    public TextMeshProUGUI ObjectiveText;
    public string Objective;
    //This is designed to be a one time trigger upon entering a new area.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            ObjectiveText.text = Objective;
            FindAnyObjectByType<AudioManager>().Play("ButtonSound");
            Destroy(gameObject);
        }
    }
}
