
using Cinemachine;
using System.Collections;
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
    [SerializeField] Collider2D cameraBounds;

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
            Reappear();
            

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
            trail.Clear(); //This will reset the trail so that it doesn't stay where the player was for a second.
        }
        spriteRenderer.enabled = true;
        StartCoroutine("Flicker");
        rigid.constraints = RigidbodyConstraints2D.FreezeRotation;
     
        transform.position = respawnPosition;
        collider.enabled = true;
        if (cameraBounds != null)
        {
            var confiner = FindAnyObjectByType<CinemachineConfiner>();
            confiner.m_BoundingShape2D = cameraBounds;
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
    }
}
