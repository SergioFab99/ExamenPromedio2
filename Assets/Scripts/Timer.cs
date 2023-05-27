using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //Establecemos el tiempo inicial
    public float timer = 60;
    public TextMeshProUGUI textoTimerPro;
    //usando la variable estatica que me recomendo el profesor tanaka 
    public static int countvictory = 0;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        //el f0 significa la cantidad de decimales que va a tener el número por ello se establece en 0
        textoTimerPro.text = "" + timer.ToString("f0");
        //Si el tiempo llega a cero ,cambiar a la escena de "Victoria"
        if (timer <= 0)
        {
            countvictory++;
            SceneManager.LoadScene("Victoria");
        }
    }
}
