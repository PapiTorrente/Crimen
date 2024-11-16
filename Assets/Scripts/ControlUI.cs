using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlUI : MonoBehaviour
{
    //Declaración de variables para pausar el juego.
    private bool estaPausado = false;
    public GameObject menuPausa;
    public AudioSource FuenteAudio;
    public GameObject controles;
    public Config configuracion;

    //Declaración de variables para abrir el inventario.
    private bool inventarioActivo = false;
    public GameObject panelInventario;

    //Declaración de variables para reproducir música.
    public AudioClip pista1, pista2, pista3, pista4;

    void Start() {
        configuracion = GameObject.FindGameObjectWithTag("Opciones").GetComponent<Config>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            activarPausa();
        }

        if(Input.GetKeyDown(KeyCode.E)) {
            activarInventario();
        }

        int numReproducir = Random.Range(1, 10);
        if(!FuenteAudio.isPlaying) {
            if(numReproducir == 8 || numReproducir == 4) {
                activarMusica();
            }
        }
    }

    private void activarPausa() {
        if(!estaPausado){ //Si no está pausado, se pausa el juego y se activa la pantalla.
            Time.timeScale = 0f;
            menuPausa.SetActive(true);
            estaPausado = true;
            FuenteAudio.volume = 0.4f;
        } else if(controles.activeSelf) {
            Time.timeScale = 0f;
            controles.SetActive(false);
            FuenteAudio.volume = 1f;
        } else if(configuracion.pantallaOpciones.activeSelf) {
            Time.timeScale = 0f;
            FuenteAudio.volume = 1f;
        } else {
            Time.timeScale = 1f;
            menuPausa.SetActive(false);
            estaPausado = false;
            FuenteAudio.volume = 1f;
        }
    }

    private void activarInventario() {
        if(!inventarioActivo){ //Si el inventario no está activo, se activa.
            inventarioActivo = true;
            panelInventario.SetActive(true);
            FuenteAudio.volume = 0.4f;
            Debug.Log("Inventario Activo");
        } else {
            inventarioActivo = false;
            panelInventario.SetActive(false);
            FuenteAudio.volume = 1f;
            Debug.Log("Inventario Desactivo");
        }
    }

    private void activarMusica(){
        int numeroPista = Random.Range(1, 4);
        if(numeroPista == 1) {
            FuenteAudio.clip = pista1;
        } else if(numeroPista == 2) {
            FuenteAudio.clip = pista2;
        } else if(numeroPista == 3) {
            FuenteAudio.clip = pista3;
        } else if(numeroPista == 4) {
            FuenteAudio.clip = pista4;
        }
        FuenteAudio.Play();
    }
}
