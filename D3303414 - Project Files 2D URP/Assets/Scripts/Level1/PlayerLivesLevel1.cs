
using UnityEngine;
using UnityEngine.UI;

public class PlayerLivesLevel1 : MonoBehaviour
{
    public float lives = 3;
    public bool hasShield = false;
    public float duration = 2;
    public Vector3 respawnPosition;
    TrailRenderer trail;
    SpriteRenderer spriteRenderer;
    Collider2D collider;
    Rigidbody2D rigid;
    public GameObject GameOver;

    private void Awake()
    {

        trail = GetComponent<TrailRenderer>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        collider = GetComponent<Collider2D>();
        rigid = GetComponent<Rigidbody2D>();
    }
    public void Hit()
    {
        lives--;
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
            }
            spriteRenderer.enabled = false;
            collider.enabled = false;
            Invoke("Reappear", 2);
            rigid.constraints = RigidbodyConstraints2D.FreezePosition;

        }
    }

    public void Heal()
    {
        lives = lives + 1;
    }

    void Reappear()
    {
        if (trail != null)
        {
            trail.enabled = true;
            trail.Clear();
        }
        spriteRenderer.enabled = true;
        rigid.constraints = RigidbodyConstraints2D.FreezeRotation;
        transform.position = respawnPosition;
        collider.enabled = true;

    }

}
