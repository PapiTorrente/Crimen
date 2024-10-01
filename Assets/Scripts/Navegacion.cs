using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navegacion : MonoBehaviour
{
    //Menú de Inicio
    public void Jugar() {
        SceneManager.LoadScene("Juego");
    }

    public void Opciones() {
        SceneManager.LoadScene("Opciones");
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
}
