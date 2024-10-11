using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class P4_RotacionEstrella : MonoBehaviour
{
     [SerializeField] float velocidad_rotacion = 10;

    void Start()
    {
        
    }
    void Update()
    {
        
        float angulo = 5f* velocidad_rotacion* -1 * Time.deltaTime;
        transform.Rotate(0,angulo,0);

    }
}


