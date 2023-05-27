using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    //inicializamos la velocidad del jugador
    public float velocidad = 5f;
    
    void Start()
    {
        
    }

    // Perdón por tantos comentarios xd
    void Update()
    {
        //Establecemos el movimiento del jugador
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * velocidad);
    }
}
