using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDeletion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Asteroid")
        {
            Destroy(other.gameObject);
        }
    }
}
