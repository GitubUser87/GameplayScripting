using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public Transform doublebulletSpawnPoint;
    public Transform double2bulletSpawnPoint;
    public Transform tripleBulletSpawnPoint;
    public Transform triple2bulletSpawnPoint;
    public Transform triple3bulletSpawnPoint;
    public GameObject bulletPrefab;
    
    public float bulletSpeed = 10;
    public float fireRate = 0.2f;
    float lastShotTime = 0;
    public bool doubleShot;
    public bool tripleShot;
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (Time.time > lastShotTime + fireRate)
            {
                if (doubleShot == false & tripleShot == false)
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
                    FindObjectOfType<AudioManager>().Play("DoubleShot");

                    //This will fire two shots instead of one.
                }

                else if (tripleShot == true)
                {
                    var bullet = Instantiate(bulletPrefab, tripleBulletSpawnPoint.position, bulletSpawnPoint.rotation);
                    bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
                    lastShotTime = Time.time;

                    var bullet2 = Instantiate(bulletPrefab, triple2bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                    bullet2.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
                    lastShotTime = Time.time;

                    var bullet3 = Instantiate(bulletPrefab, triple3bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                    bullet3.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
                    lastShotTime = Time.time;
                    FindObjectOfType<AudioManager>().Play("TripleShot");

                    //This will fire three shots instead of one or two.
                }

            }
        }
    }
}
