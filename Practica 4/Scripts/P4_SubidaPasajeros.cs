using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class P4_SubidaPasajeros : MonoBehaviour
{
    private int contadorSubidasClientes;   
    [SerializeField] TextMeshProUGUI MostrarSubidaClientes;
    void Start()
    {
        contadorSubidasClientes =0;

    }
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject obj = collision.gameObject;
        
        if(obj.CompareTag("Pasajeros")){
            Destroy(obj);
            contadorSubidasClientes++;
            Debug.Log("Clientes Subidos: "+contadorSubidasClientes);
            MostrarSubidaClientes.text = contadorSubidasClientes.ToString();
            
        }
       
    }
    public int getcontadorSubidasClientes(){
        return contadorSubidasClientes;
    }
}
