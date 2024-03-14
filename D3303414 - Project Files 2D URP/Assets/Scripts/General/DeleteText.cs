using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteText : MonoBehaviour
{
    public GameObject text;
    void Start()
    {
        Destroy(text,10);
    }

 
}
