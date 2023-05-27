using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void CambiarAEscenaNueva()
    {
        SceneManager.LoadScene("Nivel1");
    }
    //cambiar a escena de créditos
    public void CambiarAEscenaCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void CambiarAEscenaMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    //salir del juego
    public void SalirDelJuego()
    {
        Application.Quit();
    }
}