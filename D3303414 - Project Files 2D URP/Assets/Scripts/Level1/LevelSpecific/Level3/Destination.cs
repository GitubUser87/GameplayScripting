using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destination : MonoBehaviour
{
    [SerializeField] private Transform destination;
    [SerializeField] Collider2D cameraBounds;

    public Transform GetDestination() 
    { 
        if (cameraBounds != null)
        {
            var confiner = FindAnyObjectByType<CinemachineConfiner>();
            confiner.m_BoundingShape2D = cameraBounds; //This will set the players camera to the new camera bounds so that the player will still appear on screen.
        }
        return destination; 
    }   
}
