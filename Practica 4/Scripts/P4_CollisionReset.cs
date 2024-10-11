using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class P4_CollisionReset : MonoBehaviour
{
    [SerializeField] P4_SpawnPersonaje resetSpawn;
    [SerializeField] TextMeshProUGUI  TextoAdvertencia;
    [SerializeField] TextMeshProUGUI  mostrarColisiones;
    private int contadorColisiones;
    void Start()
    {
        contadorColisiones = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject obj = collision.gameObject;        
            if (obj.CompareTag("Carros") )
        {
            Destroy(obj);
            transform.position = resetSpawn.origenPersonaje.transform.position;
            contadorColisiones++;
            Debug.Log("Carros Colisonados"+contadorColisiones);
            mostrarColisiones.text = contadorColisiones.ToString();

            if(contadorColisiones>0){
                TextoAdvertencia.text = "Manejas como idiota pa'";

            }
        }
    }

    public int getcontadorColisiones(){
        return contadorColisiones;
    }   
}


