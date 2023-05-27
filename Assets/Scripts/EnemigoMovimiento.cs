using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemigoMovimiento : MonoBehaviour
{
    //Inicializamos la velocidad del enemigo y la posición del jugador
    public Transform jugador;
    public float speed = 5.0f;
    //contador de derrota
    public static int countdead = 0;
    //singleton para el contador de derrota
    //public int acumulador;
    void Start()
    {
        
    }
    public static EnemigoMovimiento instance;
    // En la actualización se moverá el enemigo hacia el jugador
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, jugador.position, speed * Time.deltaTime);
    }
    //Ahora si el enemigo colisiona con el jugador ,cargar la escena de "derrota"
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Derrota");
            //incrementar countdead
            countdead += 1;       
            Debug.Log("Derrotadas: " + countdead);
        }
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            //destruir el bullet
            Destroy(collision.gameObject);
        }
    }
}
