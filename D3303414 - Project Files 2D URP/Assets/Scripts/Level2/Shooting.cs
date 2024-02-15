using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
 
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //This will spawn in a new bullet everytime the command is initiated.
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;

            FindObjectOfType<AudioManager>().Play("PlayerShoot");
        }
    }
}
