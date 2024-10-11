using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;

public class TiempoRespuestas : MonoBehaviour  
{
    public int contadorSegundos;
    [SerializeField] P4_SubidaPasajeros subidaPasajeros;
    [SerializeField] P4_CollisionReset collisionReset;
    [SerializeField] TextMeshProUGUI TextoTiempo;
    [SerializeField] P4_CambioScena cambioScena;
    void Start()
    {
        contadorSegundos = 80;
        TextoTiempo.text = contadorSegundos--.ToString();       
        StartCoroutine("corrutinaTiempo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     IEnumerator corrutinaTiempo(){
        while(contadorSegundos>0){
            TextoTiempo.text = contadorSegundos--.ToString();
            Debug.Log(contadorSegundos);
            yield return new WaitForSeconds(0.25f);//el proceso se ejcutará cada cuarto de segundo
            
        }
        Debug.Log("El juego terminó");
        int correctas = subidaPasajeros.getcontadorSubidasClientes(); 
        Debug.Log("Obtuviste un total de " + correctas +"clientes subidos");
        int colsionados = collisionReset.getcontadorColisiones(); 
        Debug.Log("Obtuviste un total de " + colsionados +" colisiones ");
        cambioScena.cambioDeEscena(2, correctas, colsionados);
       
    }
}

