using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4_SpawnPersonaje : MonoBehaviour
{
    [SerializeField]public Transform origenPersonaje;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = origenPersonaje.transform.position;
        }
    }
}
