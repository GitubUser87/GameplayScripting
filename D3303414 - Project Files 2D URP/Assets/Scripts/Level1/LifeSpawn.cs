using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpawn : MonoBehaviour
{
    public GameObject life;
    public GameObject chest;
  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(chest);
            Instantiate(life, transform.position + new Vector3(26, 6, 0), transform.rotation);
        }
    }
}
