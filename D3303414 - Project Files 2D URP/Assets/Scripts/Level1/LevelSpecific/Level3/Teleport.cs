using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private GameObject currentTeleporter;

    void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            if (currentTeleporter != null)
            {
                transform.position = currentTeleporter.GetComponent<Destination>().GetDestination().position;
                FindObjectOfType<AudioManager>().Play("Door");
               

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
            print("Press E");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            if ( collision.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
    }
}
