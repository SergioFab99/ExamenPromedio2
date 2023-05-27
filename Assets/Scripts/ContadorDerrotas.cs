using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ContadorDerrotas : MonoBehaviour
{
    // Variables
    public TextMeshProUGUI textoDerrotas;
    int derrotas = 0;
    
    // Métodos
    private void Start()
    {
        // Inicializar el contador de escenas
        derrotas = EnemigoMovimiento.countdead;
        // aumenta el contador de escenas
        Debug.Log("Derrotas: " + derrotas);
    }
    
    private void Update()
    {
        // Actualizar el texto del contador de escenas
        textoDerrotas.text = "Derrotas: " + derrotas;
    }
}

