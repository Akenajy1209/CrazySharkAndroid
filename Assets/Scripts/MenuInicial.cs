using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
 
 public void CerrarJuego()
    {
            Application.Quit();
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void CargarNvlOne()
    {
        SceneManager.LoadScene(1);
    }
    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }
    public void Gamewin()
    {
        SceneManager.LoadScene(3);
    }
    
}
