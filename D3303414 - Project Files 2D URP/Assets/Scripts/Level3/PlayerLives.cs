
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public float lives = 3;
    public Vector3 respawnPosition;
    TrailRenderer trail;
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
            transform.position = respawnPosition;
        }
    }

}
