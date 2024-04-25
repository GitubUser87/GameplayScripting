using System.Collections;
using UnityEditor.Rendering.Universal;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    public float lives = 3;
    public bool hasShield = false;
    public float duration = 2;
    public Vector3 respawnPosition;
    TrailRenderer trail;
    SpriteRenderer spriteRenderer;
    Collider2D collider;
    
    public GameObject shield;
    public GameObject GameOver;
    public Shooting Spaceship;
    public ShootingPowerUp1 Upgrade;

    private void Awake()
    {
        Spaceship = GetComponent<Shooting>();
        Upgrade = GetComponent<ShootingPowerUp1>();
        trail = GetComponent<TrailRenderer>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        collider = GetComponent<Collider2D>();
    }
        public void Hit()
        {
            lives--;
        Shooting shooting = GetComponent<Shooting>();
        ShootingPowerUp1 upgrade = GetComponent<ShootingPowerUp1>();
        ShootingPowerUp1.fullyUpgraded = false;
        shooting.doubleShot = false;
        shooting.tripleShot = false;
        //This will set all upgrades back to the base weapon.

        if (lives == 0)
            {
                Destroy(gameObject);
            Time.timeScale = 0f;
            GameOver.SetActive(true);
        }
            else
            {
                if (trail != null)
                {
                    trail.enabled = false;
                //This will disable the trail renderer if there is one detected. 
                }
                
                collider.enabled = false;
                Reappear();
           
            transform.position = respawnPosition;

        }
        }

        public void Heal()
        {
            lives = lives + 1;
        //This will add one life when called for.
        }

        void Reappear()
        {
        var s = Instantiate(shield);
        Destroy(s, 2);
        StartCoroutine("Flicker");
        if (trail != null)
            {
                trail.enabled = true;
                trail.Clear();
            //This will renable the trail renderer.
            //The clear function will make it so that it doesn't snap to the player's position
            }
        

        

        }
        IEnumerator Flicker()
    {
        float time = 1f;
        while (time > 0)
        {
            spriteRenderer.color = new Color(1f, 1f, 1f, (Mathf.Sin(time * 50) + 1) * 0.5f);
            yield return null;
            time = time - Time.deltaTime;
        }

        spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
        collider.enabled = true;
    }
}
