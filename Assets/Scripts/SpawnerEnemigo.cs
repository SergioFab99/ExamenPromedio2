using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnerEnemigo : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public float intervaloSpawn = 1f;
    //es una variable que se utiliza para llevar un registro desde la última vez que se generó un enemigo.
    void Start()
    {
        // Invoca un nuevo enemigo en la posición del spawner cada 2 segundos
        InvokeRepeating("SpawnEnemigo", 0f, intervaloSpawn);   
    }
    void SpawnEnemigo()
    {
        //instanciar al enemigo
        Instantiate(enemigoPrefab, transform.position, Quaternion.identity);
    }
}

