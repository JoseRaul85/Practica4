using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class P4_CambioScena: MonoBehaviour
{
    [SerializeField] TextMeshProUGUI  texto_scoreCollisiones;
    [SerializeField] TextMeshProUGUI  texto_scorePasajeros;

    void Start()
    {
        
    }
    void Update()
    {
        int escena_actual = SceneManager.GetActiveScene().buildIndex;

        if(Input.GetKeyDown(KeyCode.Space)){
            if(escena_actual== 0){//escena de inicio
                cambioDeEscena(1);

            }

        }
        else if(escena_actual == 2){
            texto_scoreCollisiones.text = PlayerPrefs.GetInt("ScoreCollisiones", 0).ToString();
            texto_scorePasajeros.text = PlayerPrefs.GetInt("ScorePasajeros", 0).ToString();
            
        }
        
    }
    public void cambioDeEscena(int index_escena_ir){
        SceneManager.LoadScene(index_escena_ir);
   }

   public void cambioDeEscena(int index_escena_ir, int scoreCollisiones, int scorePasajeros){
        PlayerPrefs.SetInt("ScoreCollisiones", scoreCollisiones);
        PlayerPrefs.SetInt("ScorePasajeros", scorePasajeros);
        cambioDeEscena(index_escena_ir);

   }

}
