using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour
{
    //Declaramos el GameObject y la velocidad de la bala
    public GameObject BalaPrefab;
    public float BalaSpeed = 10f;
    //define un punto de disparo 
    public Transform puntoDisparo;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Al presionar la barra espaciadora se dispara la bala
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Crea una nueva bala en la posición del punto de disparo
            GameObject bullet = Instantiate(BalaPrefab, puntoDisparo.position, Quaternion.identity);

            // Configura la velocidad de la bala para que se mueva hacia arriba
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(0, BalaSpeed);
        }
    }
}

