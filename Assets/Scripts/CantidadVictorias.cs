using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CantidadVictorias : MonoBehaviour
{
    // Variables
    public TextMeshProUGUI textoVictorias;
    int victorias = 0;
    
    // Métodos
    private void Start()
    {
        // Inicializar el contador de escenas
        victorias = Timer.countvictory;
        // aumenta el contador de escenas
        Debug.Log("Derrotas: " + victorias);
    }
    
    private void Update()
    {
        // Actualizar el texto del contador de escenas
        textoVictorias.text = "Victorias: " + victorias;
    }
}
