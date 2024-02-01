using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControls : MonoBehaviour
{
    public GameObject door;
    public GameObject button;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            door.SetActive(false);
            button.SetActive(false);
        }
        else
        {
            door.SetActive(true);
        }
    }


}
