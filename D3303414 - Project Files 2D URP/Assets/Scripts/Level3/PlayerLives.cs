
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public float lives = 3;
    public Vector3 respawnPosition; 
    public void Hit()
    {
        lives--;
        if (lives == 0)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.position = respawnPosition;
        }
    }

}
