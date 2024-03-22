using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public Transform doublebulletSpawnPoint;
    public Transform double2bulletSpawnPoint;
    public GameObject bulletPrefab;
    
    public float bulletSpeed = 10;
    public float fireRate = 0.2f;
    float lastShotTime = 0;
    public bool doubleShot;
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (Time.time > lastShotTime + fireRate)
            {
                if (doubleShot == false)
                {

                    //This will spawn in a new bullet everytime the command is initiated.
                    var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                    bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
                    lastShotTime = Time.time;
                    FindObjectOfType<AudioManager>().Play("PlayerShoot");
                }

                else if (doubleShot == true)
                {
                    var bullet = Instantiate(bulletPrefab, doublebulletSpawnPoint.position, bulletSpawnPoint.rotation);
                    bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
                    lastShotTime = Time.time;

                    var bullet2 = Instantiate(bulletPrefab, double2bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                    bullet2.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
                    lastShotTime = Time.time;
                    FindObjectOfType<AudioManager>().Play("PlayerShoot");
                }

            }
        }
    }
}
