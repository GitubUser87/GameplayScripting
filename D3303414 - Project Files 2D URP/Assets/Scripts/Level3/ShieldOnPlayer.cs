using UnityEngine;

public class ShieldOnPlayer : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Asteroid")
        {
            if (player.TryGetComponent<PlayerLives>(out PlayerLives playerlives))
            {
                Destroy(gameObject);
                playerlives.hasShield = false;
                
                
            }

        }

        }
    }
