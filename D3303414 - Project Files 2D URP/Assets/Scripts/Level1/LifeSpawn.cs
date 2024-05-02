using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpawn : MonoBehaviour
{
    public GameObject life;
    public Vector2 spawnPosition; //This will set the spawn point above the chest.
  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Instantiate(life, transform.position + (Vector3)spawnPosition, transform.rotation);
            FindObjectOfType<AudioManager>().Play("Chest");
            Destroy(gameObject);
        }
    }
}
