using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private PlayerBehaviour PlayerData;
    private PositionBehavier Datos;
    private TimeController DatosTiempo;

    // Start is called before the first frame update
    void Start()
    {
        PlayerData = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>();
        DatosTiempo = GameObject.Find("Canvas").GetComponent<TimeController>();
      
    }
    void Update()
    {
        if (PlayerData.vidaActual <= 0 /*|| DatosTiempo.TiempoActual == 0*/)
        {
            Debug.Log("Perdio");
            SceneManager.LoadScene(2);

        }
        if (DatosTiempo.TiempoActual <= 0 )
        {
            SceneManager.LoadScene(3);
        }
    }
}
