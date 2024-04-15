using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPowerUp1 : MonoBehaviour
{
    public Transform bulletspawn;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public float fireRate = 0.2f;
    float lastShotTime = 0;
    bool equipped = false;

    private void Start()
    {
        if (equipped == false)
        {
            Destroy(gameObject, 4);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            equipped = true;
            FindObjectOfType<AudioManager>().Play("HealthPickup");
            if(other.TryGetComponent<Shooting>(out Shooting shooting))
            {
                shooting.doubleShot = true;
            }
            Destroy(gameObject);
        }
    }
}
