
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



    private void Awake()
    {

        trail = GetComponent<TrailRenderer>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        collider = GetComponent<Collider2D>();
    }
        public void Hit()
        {
            lives--;
            if (lives == 0)
            {
                Destroy(gameObject);
            }
            else
            {
                if (trail != null)
                {
                    trail.enabled = false;
                //This will disable the trail renderer if there is one detected. 
                }
               
                collider.enabled = false;
                Invoke("Reappear", 2);
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
            if (trail != null)
            {
                trail.enabled = true;
                trail.Clear();
            //This will renable the trail renderer.
            //The clear function will make t so that it doesn't snap to the player's position
            }
            
            collider.enabled = true;

        }
    
}
