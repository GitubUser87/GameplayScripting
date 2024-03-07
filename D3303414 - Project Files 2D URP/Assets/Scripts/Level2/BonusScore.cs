
using UnityEngine;

public class BonusScore : MonoBehaviour
{
    public int ScoreValue = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("PointsEarned");
            FindFirstObjectByType<AddPoints>().AddScore(ScoreValue);
            Destroy(gameObject);
        }
    }
}
