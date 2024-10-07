using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navegacion : MonoBehaviour
{
    public Configuracion Config;

    void Start() {
        Config = GameObject.FindGameObjectWithTag("Opciones").GetComponent<Configuracion>();
    }

    //Menú de Inicio
    public void Jugar() {
        SceneManager.LoadScene("Acto1");
    }

    public void Creditos() {
        SceneManager.LoadScene("Creditos");
    }

    public void Salir() {
        Debug.Log("Saliendo");
        Application.Quit();
    }

    //Pantalla de Muerte
    public void Reaparecer() {
        //SceneManager.LoadScene("Juego");
        Debug.Log("Reaparecí");
    }
    public void Regresar() {
        SceneManager.LoadScene("MenuInicio");
    }

    //Pantalla de Pausa
    public void Configuración() {
        Config.pantallaOpciones.SetActive(true);
    }

    public void SalirMenu() {
        SceneManager.LoadScene("MenuInicio");
    }

    public void SalirEscritorio() {
        Application.Quit();
    }
}
