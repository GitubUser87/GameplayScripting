
using UnityEngine;

public class RespawnShield : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void LateUpdate()
    {
        transform.position = player.transform.position;
    }
}
