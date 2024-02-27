
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public float lives = 3;
    public float duration = 2;
    public Vector3 respawnPosition;
    TrailRenderer trail;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
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
                trail.Clear();
            }
            spriteRenderer.enabled = false;
            //yield return new WaitForSeconds(duration);
            transform.position = respawnPosition;
            spriteRenderer.enabled = true;
        }
    }

    public void Heal()
    {
       lives = lives + 1;
    }

}
