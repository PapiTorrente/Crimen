using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlUI : MonoBehaviour
{
    //Declaración de variables para pausar el juego.
    private bool estaPausado = false;
    public GameObject menuPausa;
    public AudioSource FuenteAudio;

    //Declaración de variables para abrir el inventario.
    private bool inventarioActivo = false;
    public GameObject panelInventario;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            activarPausa();
        }

        if(Input.GetKeyDown(KeyCode.E)) {
            activarInventario();
        }
    }

    private void activarPausa() {
        if(!estaPausado){ //Si no está pausado, se pausa el juego y se activa la pantalla.
            Time.timeScale = 0f;
            menuPausa.SetActive(true);
            estaPausado = true;
            FuenteAudio.volume = 0.4f;
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
            Debug.Log("Inventario Activo");
        } else {
            inventarioActivo = false;
            panelInventario.SetActive(false);
            Debug.Log("Inventario Desactivo");
        }
    }
}
