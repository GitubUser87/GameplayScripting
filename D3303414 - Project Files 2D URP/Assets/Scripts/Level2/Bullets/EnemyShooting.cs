using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject Bullet;

    public float bulletSpeed = 10;
    public float fireRate = 1f;
    float lastShotTime = 0;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate (0,0,50*Time.deltaTime);
        if (Time.time > lastShotTime + fireRate)
        {
            var bullet = Instantiate(Bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
            lastShotTime = Time.time;
        }
       
    }
}
