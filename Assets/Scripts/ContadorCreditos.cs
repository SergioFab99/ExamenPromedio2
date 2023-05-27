using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ContadorCreditos : MonoBehaviour
{
    public TextMeshProUGUI textoContador;
    private int contadorClicks;

    private void Start()
    {
        contadorClicks = PlayerPrefs.GetInt("ContadorClicks", 0);
        textoContador.text = "Cantidad de veces que presionó créditos: " + contadorClicks.ToString(); // Actualizar el texto del contador con el valor almacenado en PlayerPrefs
    }

    public void OnClickCreditos()
    {
        contadorClicks++;
        textoContador.text = contadorClicks.ToString(); // Actualizar el texto del contador con el nuevo valor
        PlayerPrefs.SetInt("ContadorClicks", contadorClicks); // Almacenar el valor del contador en PlayerPrefs
    }

    private void OnApplicationQuit()
    {
        //Restablecer el valor del contador a cero al salir del juego
        PlayerPrefs.DeleteKey("ContadorClicks"); 
    }
}
