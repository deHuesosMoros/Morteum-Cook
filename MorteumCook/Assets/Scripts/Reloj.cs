using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Reloj : MonoBehaviour
{
    [Tooltip("Tiempo Inicial en Segundos")]
    public int tiempoInicial;

    [Tooltip("Escala del tiempo del reloj")]
    [Range(-10.0f, 10 - 0f)]
    public float escalaDeTiempo = 1;

    private Text mytext;
    private float tiempoDelFrameConTimeScale = 0f;
    private float timeAmostrarEnSegundos = 10f;
    private float escalaDEtiempoAlPausar, escaladeTiempoInicial;
    private bool estaPausado = false;

    // Start is called before the first frame update
    void Start()
    {
        escaladeTiempoInicial = escalaDeTiempo;

        mytext = GetComponent<Text>();

        timeAmostrarEnSegundos = tiempoInicial;

        ActualizarReloj(tiempoInicial);

    }

    // Update is called once per frame
    void Update() {
        if(!estaPausado)
        {
            tiempoDelFrameConTimeScale = Time.deltaTime * escalaDeTiempo;

            timeAmostrarEnSegundos += tiempoDelFrameConTimeScale;
            ActualizarReloj(timeAmostrarEnSegundos);
        }
        
    }

    
    public void ActualizarReloj(float tiempoEnSegundos)
    {
       
        int minutos = 0;
        int segundos = 0;
        string textoDelReloj;

        if (tiempoEnSegundos < 0) tiempoEnSegundos = 0;

        minutos = (int)tiempoEnSegundos / 60;
        segundos = (int)tiempoEnSegundos % 60;

        textoDelReloj = minutos.ToString("00") + ":" + segundos.ToString("00");

        mytext.text = textoDelReloj;
         if(minutos <=0 && segundos<= 0){
             SceneManager.LoadScene("EscGamerOver");
        }
    }



    public void Pausar()

    {
        if (!estaPausado)
        {
            estaPausado = true;
            escalaDEtiempoAlPausar = escalaDeTiempo;
            escalaDeTiempo = 0;
        }
    }
    public void Continuar()
       
     {
            if (estaPausado)
            {
                estaPausado = false;
                escalaDeTiempo = escalaDEtiempoAlPausar;
            }  
     }

    public void Reiniciar()
    {
        estaPausado = false;
        escalaDeTiempo = escaladeTiempoInicial;
        timeAmostrarEnSegundos = tiempoInicial;
        ActualizarReloj(timeAmostrarEnSegundos);
        
    }



}

